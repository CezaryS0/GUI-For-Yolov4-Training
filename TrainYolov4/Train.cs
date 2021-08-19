using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace TrainYolov4
{
    public static class Train
    {
        public static bool IsStillTraing = false;
        private static string _AvailableData;
        private static bool IsAvalilable=false;
        static Process myProcess;
        private static string AvailableData
        {
            get
            {
                return _AvailableData;
            }
            set
            {
                _AvailableData = value;
                IsAvalilable = true;
            }
        }
        public static void TrainYolov4()
        {

            IsStillTraing = true;
            myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = Config.Yolov4Path+"\\darknet.exe";
            myProcess.StartInfo.CreateNoWindow = true;
            var data = Config.ObjData;
            var cfg = Config.newcfgPath;
            var conv137 =Config.WeightsFilePath;
            myProcess.StartInfo.Arguments = "detector train ";
            myProcess.StartInfo.Arguments += data + ' ' + cfg + ' ' + conv137;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.OutputDataReceived += process_OutputDataReceived;
            myProcess.Start();
            myProcess.BeginOutputReadLine();
            myProcess.Exited += ProcessEnded;
        }
        public static void EndProcess()
        {
            IsStillTraing = false;
            if (myProcess != null)
            {
                myProcess.Kill();
                myProcess.Close();
            }
        }
        private static void ProcessEnded(object sender,EventArgs e)
        {
            IsStillTraing = false;
            if (myProcess != null)
                myProcess.Close();
        }
        public static string ReceiveData()
        {
            if(IsAvalilable)
            {
                IsAvalilable = false;
                return AvailableData;
            }
            return String.Empty;
        }
        private static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            AvailableData = e.Data;
        }
    }
}
