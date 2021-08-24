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
        private static object Lock = new object();
        static Process myProcess;
        private static ManualResetEvent mre = new ManualResetEvent(false);
        private static string AvailableData
        {
            get
            {
                    return _AvailableData;
            }
            set
            {
                    _AvailableData = value;
                
            }
        }
        public static void TrainYolov4()
        {
            FileEditor.CreateTrainFiles();
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
            mre.Set();
            if (myProcess != null)
            {
                if (!myProcess.HasExited)
                {
                    myProcess.Kill();
                    myProcess.Close();
                }
                myProcess.Dispose();
                myProcess = null;
            }
        }
        private static void ProcessEnded(object sender,EventArgs e)
        {
            IsStillTraing = false;
            mre.Set();
            if (myProcess != null)
            {
                if (!myProcess.HasExited)
                    myProcess.Close();
                myProcess.Dispose();
                myProcess = null;
            }
        }
        public static string ReceiveData()
        {
            string data = null;
            mre.WaitOne();
            lock (Lock)
            {
                mre.Reset();
                data = AvailableData;
                AvailableData = String.Empty;
            }
            return data;
        }
        private static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock (Lock)
            {
                AvailableData = e.Data;
                mre.Set();
            }
        }
    }
}
