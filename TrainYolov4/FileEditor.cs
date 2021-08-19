using System.Drawing;
using System.IO;
using System.Linq;
namespace TrainYolov4
{
    public static class FileEditor
    {
        private static int _MaxBatches = 0;
        private static int _classes = 0;
        private static int _step1 = 0;
        private static int _step2 = 0;
        private static int _yolo_filters = 0;
        private static Size _size;
        private static string ChangeBatch(string batch, int desiredBatch)
        {
            var buf = batch.Split('=');
            var newBatch = buf[0] + '=' + desiredBatch.ToString();
            return newBatch;
        }
        private static string ChangeSubdivisions(string batch, int desiredSubdivision)
        {
            var buf = batch.Split('=');
            var newBatch = buf[0] + '=' + desiredSubdivision.ToString();
            return newBatch;
        }
        private static string ChangeMaxBatches(string max_batches)
        {
            var buf = max_batches.Split('=');
            var newMaxBatches = buf[0] + '=' + _MaxBatches.ToString();
            return newMaxBatches;
        }
        private static string ChangeSteps(string steps)
        {
            var buf = steps.Split('=');
            var newSteps = buf[0] + '=';
            newSteps += _step1.ToString() + ',';
            newSteps += _step2.ToString();
            return newSteps;
        }
        private static string ChangeWidth(string w)
        {
            var buf = w.Split('=');
            var newWidth = buf[0] + '=' + _size.Width.ToString();
            return newWidth;
        }
        private static string ChangeHeight(string w)
        {
            var buf = w.Split('=');
            var newHeight = buf[0] + '=' + _size.Height.ToString();
            return newHeight;
        }
        private static string ChangeClasses(string classes)
        {
            var buf = classes.Split('=');
            var newClasses = buf[0] + '=' + _classes.ToString();
            return newClasses;
        }
        private static string ChangeValues(string line)
        {
            var buf = line.Split('=');
            switch (buf[0])
            {
                case "batch":
                    {
                        return ChangeBatch(line, ConfigCFG.batch);
                    }
                case "subdivisions":
                    {
                        return ChangeSubdivisions(line, ConfigCFG.subdivisions);
                    }
                case "max_batches":
                    {
                        return ChangeMaxBatches(line);
                    }
                case "steps":
                    {
                        return ChangeSteps(line);
                    }
                case "width":
                    {
                        return ChangeWidth(line);
                    }
                case "height":
                    {
                        return ChangeHeight(line);
                    }
                case "classes":
                    {
                        return ChangeClasses(line);
                    }
            }
            return line;
        }
        private static int CountClasses()
        {
            int i = 0;
            using(var objnames=new StreamReader(Config.ObjNames))
            {
                while (objnames.ReadLine() != null)
                    i++;
            }
            return i;
        }
        public static void GenerateObjData()
        {
            using (var newobjdata = new StreamWriter(Config.ObjData,false))
            {
                newobjdata.WriteLine("classes = " + _classes.ToString());
                newobjdata.WriteLine("train = "+Config.TrainTXT);
                newobjdata.WriteLine("valid  = "+Config.TestTXT);
                newobjdata.WriteLine("names = "+Config.ObjNames);
                newobjdata.WriteLine("backup = "+Config.backupPath);
            }
        }
        public static void GenerateTrainTXT()
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
            Config.ObjData = Config.Yolov4Path + "\\data\\obj.data";
            Config.ObjNames = Config.Yolov4Path + "\\data\\obj.names";
            Config.TrainTXT = Config.Yolov4Path + "\\data\\train.txt";
            Config.TestTXT = Config.Yolov4Path + "\\data\\test.txt";
            Config.newcfgPath = Config.Yolov4Path+"\\yolo-obj.cfg";
        }
        private static void CalculateConfigData()
        {
            _size = ConfigCFG.NetworkSize;
            _classes = CountClasses();
            _MaxBatches = _classes * 2000;
            _step1 = (_MaxBatches * 8) / 10;
            _step2 = (_MaxBatches * 9) / 10;
            _yolo_filters = (_classes + 5) * 3;
        }
        public static void GenerateFile()
        {
            CreatePaths();
            CalculateConfigData();
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
