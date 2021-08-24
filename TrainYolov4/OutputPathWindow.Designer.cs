
namespace TrainYolov4
{
    partial class OutputPathWindow
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
            this.OutputModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputModelTextBox
            // 
            this.OutputModelTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputModelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OutputModelTextBox.Location = new System.Drawing.Point(12, 34);
            this.OutputModelTextBox.Name = "OutputModelTextBox";
            this.OutputModelTextBox.ReadOnly = true;
            this.OutputModelTextBox.Size = new System.Drawing.Size(248, 20);
            this.OutputModelTextBox.TabIndex = 42;
            // 
            // ModelPath
            // 
            this.ModelPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModelPath.FlatAppearance.BorderSize = 0;
            this.ModelPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ModelPath.Location = new System.Drawing.Point(12, 60);
            this.ModelPath.Name = "ModelPath";
            this.ModelPath.Size = new System.Drawing.Size(123, 34);
            this.ModelPath.TabIndex = 41;
            this.ModelPath.Text = "PathToOuput";
            this.ModelPath.UseVisualStyleBackColor = false;
            this.ModelPath.Click += new System.EventHandler(this.ModelPath_Click);
            this.ModelPath.MouseEnter += new System.EventHandler(this.HoverOn);
            this.ModelPath.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "OutputModelPath";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SubmitButton.Location = new System.Drawing.Point(0, 141);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(324, 85);
            this.SubmitButton.TabIndex = 43;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SubmitButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.SubmitButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.OutputModelTextBox);
            this.panel1.Controls.Add(this.ModelPath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 108);
            this.panel1.TabIndex = 44;
            // 
            // OutputPathWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(324, 226);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputPathWindow";
            this.Text = "OutputPathWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OutputModelTextBox;
        private System.Windows.Forms.Button ModelPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel panel1;
    }
}