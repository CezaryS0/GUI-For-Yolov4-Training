using System;
using System.Threading;
using System.Windows.Forms;
namespace TrainYolov4
{
    public partial class Form1 : Form
    {
        private Thread thread, TrainThread;
        private Semaphore A = new Semaphore(0, 1);
        private Semaphore B = new Semaphore(0, 1);
        private bool PathSet = false;
        private bool CFGSet = false;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            InitThreads();
        }
        private void InitThreads()
        {
            TrainThread = new Thread(Train_T);
            TrainThread.IsBackground = true;
            TrainThread.Start();
            thread = new Thread(EditFile);
            thread.IsBackground = true;
            thread.Start();
        }
        private void BlockAllButtons(Control con, bool set)
        {
            foreach (Control c in con.Controls)
            {
                BlockAllButtons(c, set);

            }
            if (con is Button)
            {
                var bt = con as Button;

                if (bt.InvokeRequired)
                {
                    bt.BeginInvoke((MethodInvoker)delegate
                    {
                        bt.Enabled = set;
                    });
                }
                else
                {
                    bt.Enabled = set;
                }
            }
        }
        private void BlockStopButton(bool b)
        {
            if (StopTrainingButton.InvokeRequired)
            {
                StopTrainingButton.BeginInvoke((MethodInvoker)delegate
                {
                    StopTrainingButton.Enabled = b;

                });
            }
            else
            {
                StopTrainingButton.Enabled = b;
            }
        }
        private void Train_T()
        {
            while (true)
            {
                B.WaitOne();
                Train.TrainYolov4();
                while (Train.IsStillTraing)
                {
                    var data = Train.ReceiveData();
                    if (data != String.Empty)
                    {
                        if (TrainingOutput.InvokeRequired)
                        {
                            TrainingOutput.BeginInvoke((MethodInvoker)delegate
                            {
                                TrainingOutput.AppendText(Environment.NewLine + data);
                            }
                            );
                        }
                        else
                            TrainingOutput.AppendText(Environment.NewLine + data);

                    }
                }
                BlockAllButtons(this,true);
                BlockStopButton(false);
            }
        }
        private void EditFile()
        {
            while (true)
            {
                A.WaitOne();
                FileEditor.GenerateFile();
                FileEditor.GenerateObjData();
                FileEditor.GenerateTrainTXT();
                BlockAllButtons(this,true);
                BlockStopButton(false);
                MessageBox.Show("CFG file generated!", "Success!");
            }
        }

        private void ConfigurePathsButton_Click(object sender, EventArgs e)
        {
            using (PathWindow pathWindow = new PathWindow())
            {
                if (pathWindow.ShowDialog() == DialogResult.OK)
                {
                    PathSet = true;
                }
                else
                    PathSet = false;
            }
            this.ActiveControl = null;
        }

        private void ConfigureCfgButton_Click(object sender, EventArgs e)
        {
            using (ConfigWindow configWindow = new ConfigWindow())
            {
                if (configWindow.ShowDialog() == DialogResult.OK)
                {
                    CFGSet = true;
                }
                else
                    CFGSet = false;
            }
            this.ActiveControl = null;
        }

        private void StopTrainingButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Train.EndProcess();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Train.EndProcess();
        }

        private void HoverOn(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.FlatAppearance.BorderSize = 1;
        }
        private void HoverOff(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateCFGButton_Click(object sender, EventArgs e)
        {
            if (PathSet == true && CFGSet == true)
            {
                BlockAllButtons(this, false);
                A.Release();
            }
            else
            {
                MessageBox.Show("Not all data has been set!", "Error!");
            }
            this.ActiveControl = null;
        }

        private void TrainingOutput_TextChanged(object sender, EventArgs e)
        {
            var control = sender as RichTextBox;
            control.SelectionStart = control.Text.Length;
            control.ScrollToCaret();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            if (PathSet == true && CFGSet == true)
            {
                BlockAllButtons(this,false);
                BlockStopButton(true);
                B.Release();
            }
            this.ActiveControl = null;
        }
    }
}
