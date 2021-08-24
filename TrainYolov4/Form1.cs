using System;
using System.Threading;
using System.Windows.Forms;
namespace TrainYolov4
{
    public partial class Form1 : Form
    {
        private Thread thread, TrainThread;
        ManualResetEvent A = new ManualResetEvent(false);
        ManualResetEvent B = new ManualResetEvent(false);
        private bool PathSet = false;
        private bool CFGSet = false;
        private bool OutputSet = false;
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
                B.Reset();
                Train.TrainYolov4();
                while (Train.IsStillTraing)
                {
                    var data = Train.ReceiveData();
                    if (data != String.Empty)
                    {
                        if (TrainingOutput.InvokeRequired)
                        {
                            TrainingOutput.Invoke((MethodInvoker)delegate
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
                A.Reset();
                FileEditor.GenerateFile();
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
            if(CFGSet==false)
            {
                MessageBox.Show("Check your CFG config!", "Error!");
                return;
            }
            if(OutputSet==false)
            {
                MessageBox.Show("No output path specified!", "Error!");
                return;
            }
            BlockAllButtons(this, false);
            A.Set();
            this.ActiveControl = null;
        }

        private void TrainingOutput_TextChanged(object sender, EventArgs e)
        {
            var control = sender as RichTextBox;
            control.SelectionStart = control.Text.Length;
            control.ScrollToCaret();
        }

        private void ConfigureOutputButton_Click(object sender, EventArgs e)
        {
            using(var window = new OutputPathWindow())
            {
                if (window.ShowDialog() == DialogResult.OK)
                {
                    OutputSet = true;
                }
            }
            this.ActiveControl = null;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            if(!PathSet)
            {
                MessageBox.Show("Paths have not been configured!", "Error!");
                return;
            }
            if(!OutputSet)
            {
                if (OutputSet == false)
                {
                    MessageBox.Show("No output path specified!", "Error!");
                    return;
                }
            }
                BlockAllButtons(this,false);
                BlockStopButton(true);
            B.Set();
            this.ActiveControl = null;
        }
    }
}
