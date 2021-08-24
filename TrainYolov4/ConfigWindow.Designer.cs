
namespace TrainYolov4
{
    partial class ConfigWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BatchTextBox = new System.Windows.Forms.TextBox();
            this.subdivisionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NetworkHeightTextBox = new System.Windows.Forms.TextBox();
            this.NetworkWidthTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CFGTextBox = new System.Windows.Forms.TextBox();
            this.PathToCfgButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClassesTextBox = new System.Windows.Forms.TextBox();
            this.NamesTXTTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.NamesPanel = new System.Windows.Forms.Panel();
            this.NamesTXTButton = new System.Windows.Forms.Button();
            this.ClassesPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NamesPanel.SuspendLayout();
            this.ClassesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BatchTextBox
            // 
            this.BatchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BatchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BatchTextBox.Location = new System.Drawing.Point(13, 35);
            this.BatchTextBox.Name = "BatchTextBox";
            this.BatchTextBox.Size = new System.Drawing.Size(100, 20);
            this.BatchTextBox.TabIndex = 0;
            this.BatchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalKeyPress);
            // 
            // subdivisionsTextBox
            // 
            this.subdivisionsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subdivisionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subdivisionsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subdivisionsTextBox.Location = new System.Drawing.Point(13, 106);
            this.subdivisionsTextBox.Name = "subdivisionsTextBox";
            this.subdivisionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.subdivisionsTextBox.TabIndex = 1;
            this.subdivisionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "subdivisions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(128, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Network Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(128, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Network Width";
            // 
            // NetworkHeightTextBox
            // 
            this.NetworkHeightTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NetworkHeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetworkHeightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NetworkHeightTextBox.Location = new System.Drawing.Point(131, 106);
            this.NetworkHeightTextBox.Name = "NetworkHeightTextBox";
            this.NetworkHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.NetworkHeightTextBox.TabIndex = 5;
            this.NetworkHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalKeyPress);
            // 
            // NetworkWidthTextBox
            // 
            this.NetworkWidthTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NetworkWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetworkWidthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NetworkWidthTextBox.Location = new System.Drawing.Point(131, 35);
            this.NetworkWidthTextBox.Name = "NetworkWidthTextBox";
            this.NetworkWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.NetworkWidthTextBox.TabIndex = 4;
            this.NetworkWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalKeyPress);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.Location = new System.Drawing.Point(0, 308);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(578, 63);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SubmitButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.SubmitButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // CFGTextBox
            // 
            this.CFGTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CFGTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CFGTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CFGTextBox.Location = new System.Drawing.Point(13, 40);
            this.CFGTextBox.Name = "CFGTextBox";
            this.CFGTextBox.ReadOnly = true;
            this.CFGTextBox.Size = new System.Drawing.Size(218, 20);
            this.CFGTextBox.TabIndex = 38;
            // 
            // PathToCfgButton
            // 
            this.PathToCfgButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PathToCfgButton.FlatAppearance.BorderSize = 0;
            this.PathToCfgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathToCfgButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PathToCfgButton.Location = new System.Drawing.Point(13, 66);
            this.PathToCfgButton.Name = "PathToCfgButton";
            this.PathToCfgButton.Size = new System.Drawing.Size(100, 34);
            this.PathToCfgButton.TabIndex = 37;
            this.PathToCfgButton.Text = "PathToCFG";
            this.PathToCfgButton.UseVisualStyleBackColor = false;
            this.PathToCfgButton.Click += new System.EventHandler(this.PathToCfgButton_Click);
            this.PathToCfgButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.PathToCfgButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Yolo-custom.cfg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Classes";
            // 
            // ClassesTextBox
            // 
            this.ClassesTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClassesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClassesTextBox.Location = new System.Drawing.Point(16, 35);
            this.ClassesTextBox.Name = "ClassesTextBox";
            this.ClassesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesTextBox.TabIndex = 39;
            // 
            // NamesTXTTextBox
            // 
            this.NamesTXTTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NamesTXTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamesTXTTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NamesTXTTextBox.Location = new System.Drawing.Point(16, 40);
            this.NamesTXTTextBox.Name = "NamesTXTTextBox";
            this.NamesTXTTextBox.ReadOnly = true;
            this.NamesTXTTextBox.Size = new System.Drawing.Size(227, 20);
            this.NamesTXTTextBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(13, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "NamesTxtPath";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(422, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 17);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Enter Number of classes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(422, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 30);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Count number of classes \r\nfrom .names file";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // NamesPanel
            // 
            this.NamesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamesPanel.Controls.Add(this.NamesTXTButton);
            this.NamesPanel.Controls.Add(this.label7);
            this.NamesPanel.Controls.Add(this.NamesTXTTextBox);
            this.NamesPanel.Enabled = false;
            this.NamesPanel.Location = new System.Drawing.Point(286, 182);
            this.NamesPanel.Name = "NamesPanel";
            this.NamesPanel.Size = new System.Drawing.Size(276, 113);
            this.NamesPanel.TabIndex = 46;
            // 
            // NamesTXTButton
            // 
            this.NamesTXTButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NamesTXTButton.FlatAppearance.BorderSize = 0;
            this.NamesTXTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NamesTXTButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NamesTXTButton.Location = new System.Drawing.Point(16, 66);
            this.NamesTXTButton.Name = "NamesTXTButton";
            this.NamesTXTButton.Size = new System.Drawing.Size(134, 35);
            this.NamesTXTButton.TabIndex = 42;
            this.NamesTXTButton.Text = "Path to TXT with names";
            this.NamesTXTButton.UseVisualStyleBackColor = false;
            this.NamesTXTButton.Click += new System.EventHandler(this.NamesTXTButton_Click);
            this.NamesTXTButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.NamesTXTButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // ClassesPanel
            // 
            this.ClassesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassesPanel.Controls.Add(this.ClassesTextBox);
            this.ClassesPanel.Controls.Add(this.label6);
            this.ClassesPanel.Enabled = false;
            this.ClassesPanel.Location = new System.Drawing.Point(286, 12);
            this.ClassesPanel.Name = "ClassesPanel";
            this.ClassesPanel.Size = new System.Drawing.Size(130, 82);
            this.ClassesPanel.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PathToCfgButton);
            this.panel2.Controls.Add(this.CFGTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 113);
            this.panel2.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NetworkWidthTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NetworkHeightTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BatchTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subdivisionsTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 154);
            this.panel1.TabIndex = 49;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(578, 371);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NamesPanel);
            this.Controls.Add(this.ClassesPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.Text = "Set Values for config file!";
            this.Load += new System.EventHandler(this.ConfigWindow_Load);
            this.NamesPanel.ResumeLayout(false);
            this.NamesPanel.PerformLayout();
            this.ClassesPanel.ResumeLayout(false);
            this.ClassesPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BatchTextBox;
        private System.Windows.Forms.TextBox subdivisionsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NetworkHeightTextBox;
        private System.Windows.Forms.TextBox NetworkWidthTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox CFGTextBox;
        private System.Windows.Forms.Button PathToCfgButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClassesTextBox;
        private System.Windows.Forms.TextBox NamesTXTTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel NamesPanel;
        private System.Windows.Forms.Panel ClassesPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NamesTXTButton;
    }
}