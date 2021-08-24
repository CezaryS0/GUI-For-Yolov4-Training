using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainYolov4
{
    public partial class OutputPathWindow : Form
    {
        public OutputPathWindow()
        {
            InitializeComponent();
            this.OutputModelTextBox.Text = Config.ModelOutPath;
            this.CenterToParent();
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
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(OutputModelTextBox.Text!="")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
        private void ModelPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    OutputModelTextBox.Text = fbd.SelectedPath;
                    Config.ModelOutPath = fbd.SelectedPath;
                }
            }
        }
    }
}
