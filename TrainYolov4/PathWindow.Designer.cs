
namespace TrainYolov4
{
    partial class PathWindow
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
            this.WeightsPathButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TrainPhotosPathButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TrainPhotosTextBox = new System.Windows.Forms.TextBox();
            this.WeightsTextBox = new System.Windows.Forms.TextBox();
            this.DarknetTextBox = new System.Windows.Forms.TextBox();
            this.DarknetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeightsPathButton
            // 
            this.WeightsPathButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeightsPathButton.FlatAppearance.BorderSize = 0;
            this.WeightsPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeightsPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WeightsPathButton.Location = new System.Drawing.Point(16, 212);
            this.WeightsPathButton.Name = "WeightsPathButton";
            this.WeightsPathButton.Size = new System.Drawing.Size(123, 34);
            this.WeightsPathButton.TabIndex = 25;
            this.WeightsPathButton.Text = "Path to Weights file";
            this.WeightsPathButton.UseVisualStyleBackColor = false;
            this.WeightsPathButton.Click += new System.EventHandler(this.WeightsPathButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "WeightsPath";
            // 
            // TrainPhotosPathButton
            // 
            this.TrainPhotosPathButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrainPhotosPathButton.FlatAppearance.BorderSize = 0;
            this.TrainPhotosPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainPhotosPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TrainPhotosPathButton.Location = new System.Drawing.Point(16, 85);
            this.TrainPhotosPathButton.Name = "TrainPhotosPathButton";
            this.TrainPhotosPathButton.Size = new System.Drawing.Size(123, 34);
            this.TrainPhotosPathButton.TabIndex = 19;
            this.TrainPhotosPathButton.Text = "PathToTrainPhotos";
            this.TrainPhotosPathButton.UseVisualStyleBackColor = false;
            this.TrainPhotosPathButton.Click += new System.EventHandler(this.TrainPhotosPathButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "TrainPhotos (with .txts!)";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SubmitButton.Location = new System.Drawing.Point(0, 271);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(666, 77);
            this.SubmitButton.TabIndex = 34;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TrainPhotosTextBox
            // 
            this.TrainPhotosTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrainPhotosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrainPhotosTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TrainPhotosTextBox.Location = new System.Drawing.Point(16, 45);
            this.TrainPhotosTextBox.Name = "TrainPhotosTextBox";
            this.TrainPhotosTextBox.ReadOnly = true;
            this.TrainPhotosTextBox.Size = new System.Drawing.Size(296, 20);
            this.TrainPhotosTextBox.TabIndex = 36;
            // 
            // WeightsTextBox
            // 
            this.WeightsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeightsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WeightsTextBox.Location = new System.Drawing.Point(6, 49);
            this.WeightsTextBox.Name = "WeightsTextBox";
            this.WeightsTextBox.ReadOnly = true;
            this.WeightsTextBox.Size = new System.Drawing.Size(296, 20);
            this.WeightsTextBox.TabIndex = 37;
            // 
            // DarknetTextBox
            // 
            this.DarknetTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DarknetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DarknetTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DarknetTextBox.Location = new System.Drawing.Point(349, 45);
            this.DarknetTextBox.Name = "DarknetTextBox";
            this.DarknetTextBox.ReadOnly = true;
            this.DarknetTextBox.Size = new System.Drawing.Size(296, 20);
            this.DarknetTextBox.TabIndex = 42;
            // 
            // DarknetButton
            // 
            this.DarknetButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DarknetButton.FlatAppearance.BorderSize = 0;
            this.DarknetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarknetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DarknetButton.Location = new System.Drawing.Point(349, 81);
            this.DarknetButton.Name = "DarknetButton";
            this.DarknetButton.Size = new System.Drawing.Size(123, 35);
            this.DarknetButton.TabIndex = 41;
            this.DarknetButton.Text = "Path to Darknet.exe";
            this.DarknetButton.UseVisualStyleBackColor = false;
            this.DarknetButton.Click += new System.EventHandler(this.DarknetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Yolov4Path";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(335, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 119);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 119);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.WeightsTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(10, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 127);
            this.panel3.TabIndex = 45;
            // 
            // PathWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(666, 348);
            this.Controls.Add(this.DarknetTextBox);
            this.Controls.Add(this.DarknetButton);
            this.Controls.Add(this.TrainPhotosTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.WeightsPathButton);
            this.Controls.Add(this.TrainPhotosPathButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathWindow";
            this.Text = "PathWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WeightsPathButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TrainPhotosPathButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox TrainPhotosTextBox;
        private System.Windows.Forms.TextBox WeightsTextBox;
        private System.Windows.Forms.TextBox DarknetTextBox;
        private System.Windows.Forms.Button DarknetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}