using System.Drawing;
using System.IO;
using System.Linq;
using System;
namespace TrainYolov4
{
    public static class FileEditor
    {
        private static int _MaxBatches = 0;
        private static int _classes = 0;
        private static int _step1 = 0;
        private static int _step2 = 0;
        private static int _yolo_filters = 0;
        private static string ChangeValues(string line)
        {
            var buf = line.Split('=');
            switch (buf[0])
            {
                case "batch":
                    {
                        return buf[0] + '=' + ConfigCFG.batch;
                    }
                case "subdivisions":
                    {
                        return buf[0] + '=' + ConfigCFG.subdivisions;
                    }
                case "max_batches":
                    {
                        return buf[0] + '=' + _MaxBatches.ToString();
                    }
                case "steps":
                    {
                        var newSteps = buf[0] + '=';
                        newSteps += _step1.ToString() + ',';
                        newSteps += _step2.ToString();
                        return newSteps;
                    }
                case "width":
                    {
                        return buf[0] + '=' + ConfigCFG.Width;
                    }
                case "height":
                    {
                        return buf[0] + '=' + ConfigCFG.Height;
                    }
                case "classes":
                    {
                        return  buf[0] + '=' + ConfigCFG.classes;
                    }
            }
            return line;
        }
        private static int CountClasses()
        {
            int i = 0;
            using(var objnames=new StreamReader(Config.ObjNames))
            {
                string buf = null;
                while ((buf=objnames.ReadLine()) != null)
                {
                    if (buf == "\n")
                        continue;
                    i++;
                }
                   
            }
            return i;
        }
        public static void CreateTrainFiles()
        {
            CreatePaths();
            GenerateObjData();
            GenerateTrainTXT();
        }
        private static void GenerateObjData()
        {
            using (var newobjdata = new StreamWriter(Config.ObjData,false))
            {
                newobjdata.WriteLine("classes = " + ConfigCFG.classes);
                newobjdata.WriteLine("train = "+Config.TrainTXT);
                newobjdata.WriteLine("valid  = "+Config.TestTXT);
                newobjdata.WriteLine("names = "+Config.ObjNames);
                newobjdata.WriteLine("backup = "+Config.ModelOutPath);
            }
        }
        private static void GenerateTrainTXT()
        {
            using(var file=new StreamWriter(Config.TrainTXT,false))
            {
                foreach (string f in Directory.GetFiles(Config.TrainPhtPath))
                {
                    if(Path.GetExtension(f)!=".txt")
                        file.WriteLine(f);
                }
            }
        }
        private static void CreatePaths()
        {
            if (!Directory.Exists(Config.ModelOutPath + "\\data"))
                Directory.CreateDirectory(Config.ModelOutPath + "\\data");
            Config.ObjData = Config.ModelOutPath + "\\data\\obj.data";
            Config.TrainTXT = Config.ModelOutPath + "\\data\\train.txt";
            Config.TestTXT = Config.ModelOutPath + "\\data\\test.txt";
        }
        private static void CalculateConfigData()
        {
            if (ConfigCFG.CalculateDuringGeneration)
            {
                _classes = CountClasses();
                ConfigCFG.classes = _classes.ToString();
            }
            else
                _classes = Convert.ToInt32(ConfigCFG.classes);
            _MaxBatches = _classes * 2000;
            _step1 = (_MaxBatches * 8) / 10;
            _step2 = (_MaxBatches * 9) / 10;
            _yolo_filters = (_classes + 5) * 3;
        }
        public static void GenerateFile()
        {
            CalculateConfigData();
            Config.newcfgPath = Config.ModelOutPath + "\\yolo-obj.cfg";
            Convolutional convolutional = new Convolutional();
            using (var cfgfile = new StreamReader(Config.cfgPath))
            using (var newcfgfile = new StreamWriter(Config.newcfgPath,false))
            {
                string line;
                while ((line = cfgfile.ReadLine()) != null)
                {
                    if (line.Contains('='))
                    {
                        newcfgfile.WriteLine(ChangeValues(line));
                    }
                    else if (line == "[convolutional]")
                    {
                        newcfgfile.WriteLine(line);
                        string next = cfgfile.ReadLine();
                        if (next.StartsWith("size="))
                        {
                            convolutional.ReadConvolutional(cfgfile, next);
                            convolutional.FlushLastConvolutional(newcfgfile, _yolo_filters);
                        }
                        else
                        {
                            newcfgfile.WriteLine(next);
                        }
                    }
                    else
                    {
                        newcfgfile.WriteLine(line);
                    }
                }
            }
        }
    }
}
