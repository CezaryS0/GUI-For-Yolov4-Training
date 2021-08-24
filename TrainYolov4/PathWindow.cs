using System;
using System.IO;
using System.Windows.Forms;

namespace TrainYolov4
{
    public partial class PathWindow : Form
    {
        private bool CheckIfAllDataIsSet()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    var label = c as Label;
                    if (label.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void InitValues()
        {
            this.DialogResult = DialogResult.None;
            TrainPhotosTextBox.Text = Config.TrainPhtPath;
            WeightsTextBox.Text = Config.WeightsFilePath;
            DarknetTextBox.Text = Config.Yolov4Path;
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
        private void SetAnimation()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    var bt = c as Button;
                    bt.MouseEnter += HoverOn;
                    bt.TabStop = false;
                    bt.MouseLeave += HoverOff;
                }
            }

        }
        public PathWindow()
        {
            InitializeComponent();
            InitValues();
            SetAnimation();
            this.CenterToParent();
        }
        private void TrainPhotosPathButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    TrainPhotosTextBox.Text = fbd.SelectedPath;
                    Config.TrainPhtPath = fbd.SelectedPath;
                }
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (CheckIfAllDataIsSet())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;

            }
            this.Close();
        }

        private void DarknetButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (File.Exists(fbd.SelectedPath + "\\darknet.exe"))
                    {
                        DarknetTextBox.Text = fbd.SelectedPath;
                        Config.Yolov4Path = fbd.SelectedPath;
                    }
                    else
                        MessageBox.Show("Darknet.exe not found in selected location", "Error!");
                }
            }
        }

        private void WeightsPathButton_Click(object sender, EventArgs e)
        {
            int[] tab = new int[] { 11, 29, 74, 112, 132, 137 };
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = String.Format("{0} files (*.{0})|*.{0}", tab[0]);
                for (int i = 1; i < tab.Length; i++)
                    openFileDialog.Filter += String.Format("|{0} files (*.{0})|*.{0}", tab[i]);
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    WeightsTextBox.Text = openFileDialog.FileName;
                    Config.WeightsFilePath = openFileDialog.FileName;
                }
            }
        }
    }
}
