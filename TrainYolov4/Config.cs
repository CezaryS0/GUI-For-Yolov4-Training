using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TrainYolov4
{
    public static class Config
    {
        public static string Yolov4Path = "";
        public static string cfgPath="";
        public static string newcfgPath="";
        public static string TrainPhtPath = "";
        public static string ModelOutPath = "";
        public static string TrainTXT = "";
        public static string TestTXT = "";
        public static string ObjData = "";
        public static string ObjNames = "";
        public static string WeightsFilePath= "";
        public static string backupPath= "";
       
    }
    public static class ConfigCFG
    {
        public static int batch;
        public static int subdivisions;
        public static Size NetworkSize;
    }
}
