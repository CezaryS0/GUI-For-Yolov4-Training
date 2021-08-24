using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace TrainYolov4
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow()
        {
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            this.DialogResult = DialogResult.None;
            this.BatchTextBox.Text = ConfigCFG.batch;
            this.subdivisionsTextBox.Text = ConfigCFG.subdivisions;
            this.NetworkHeightTextBox.Text = ConfigCFG.Height;
            this.NetworkWidthTextBox.Text = ConfigCFG.Width;
            this.ClassesTextBox.Text = ConfigCFG.classes;
            this.CFGTextBox.Text = Config.cfgPath;
            this.NamesTXTTextBox.Text = Config.ObjNames;
            if (!ConfigCFG.CalculateDuringGeneration)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }
        private bool CheckIfAllDataIsSet()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    var textBox = c as TextBox;
                    if (textBox.Enabled == false)
                        continue;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void ConfigWindow_Load(object sender, EventArgs e)
        {
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
        private void GlobalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void SetData()
        {
            ConfigCFG.batch =BatchTextBox.Text;
            ConfigCFG.subdivisions = subdivisionsTextBox.Text;
            ConfigCFG.Width = NetworkWidthTextBox.Text;
            ConfigCFG.Height = NetworkHeightTextBox.Text;
            var radioButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            switch (radioButton.Name)
            {
                case "radioButton1":
                    ConfigCFG.classes = ClassesTextBox.Text;
                    ConfigCFG.CalculateDuringGeneration = false;
                    break;
                case "radioButton2":
                    ConfigCFG.CalculateDuringGeneration = true;
                    break;
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(CheckIfAllDataIsSet())
            {
                int x = Convert.ToInt32(NetworkWidthTextBox.Text);
                int y = Convert.ToInt32(NetworkHeightTextBox.Text);
                if (x % 32 == 0 && y % 32 == 0)
                {
                    SetData();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this,"Width and Height must be divisible by 32 !", "Warning!");
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }
        private void CheckChanged(object sender, EventArgs e)
        {
            var checkedButton = sender as RadioButton;
            switch(checkedButton.Name)
            {
                case "radioButton1":
                    ClassesPanel.Enabled = true;
                    NamesPanel.Enabled = false;
                    break;
                case "radioButton2":
                    ClassesPanel.Enabled = false;
                    NamesPanel.Enabled = true;
                    break;
            }
        }
        private void PathToCfgButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "cfg files (*.cfg)|*.cfg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CFGTextBox.Text = openFileDialog.FileName;
                    Config.cfgPath = openFileDialog.FileName;
                }
            }
        }
        private void NamesTXTButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = ".names files (*.names)|*.names";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    NamesTXTTextBox.Text = openFileDialog.FileName;
                    Config.ObjNames = openFileDialog.FileName;
                }
            }
        }
    }
}
