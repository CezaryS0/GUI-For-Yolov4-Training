
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
            this.SuspendLayout();
            // 
            // BatchTextBox
            // 
            this.BatchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BatchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BatchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BatchTextBox.Location = new System.Drawing.Point(12, 47);
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
            this.subdivisionsTextBox.Location = new System.Drawing.Point(12, 118);
            this.subdivisionsTextBox.Name = "subdivisionsTextBox";
            this.subdivisionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.subdivisionsTextBox.TabIndex = 1;
            this.subdivisionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "subdivisions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(135, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Network Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(135, 28);
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
            this.NetworkHeightTextBox.Location = new System.Drawing.Point(134, 118);
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
            this.NetworkWidthTextBox.Location = new System.Drawing.Point(134, 47);
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
            this.SubmitButton.Location = new System.Drawing.Point(0, 144);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(246, 76);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SubmitButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.SubmitButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 220);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetworkHeightTextBox);
            this.Controls.Add(this.NetworkWidthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subdivisionsTextBox);
            this.Controls.Add(this.BatchTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.Text = "Set Values for config file!";
            this.Load += new System.EventHandler(this.ConfigWindow_Load);
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
    }
}