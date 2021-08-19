using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrainYolov4
{
    public partial class ConfigWindow : Form
    {
        public ConfigWindow()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }
        private bool CheckIfAllDataIsSet()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    var textBox = c as TextBox;
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
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(CheckIfAllDataIsSet())
            {
                ConfigCFG.batch = Convert.ToInt32(BatchTextBox.Text);
                ConfigCFG.subdivisions = Convert.ToInt32(subdivisionsTextBox.Text);
                int x = Convert.ToInt32(NetworkWidthTextBox.Text);
                int y = Convert.ToInt32(NetworkHeightTextBox.Text);
                if (x % 32 == 0 && y % 32 == 0)
                {
                    ConfigCFG.NetworkSize = new Size(x, y);
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
    }
}
