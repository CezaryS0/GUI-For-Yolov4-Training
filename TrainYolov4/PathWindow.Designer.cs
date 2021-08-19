
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
            this.ModelPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TrainPhotosPathButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PathToCfgButton = new System.Windows.Forms.Button();
            this.NamesTXTButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CFGTextBox = new System.Windows.Forms.TextBox();
            this.TrainPhotosTextBox = new System.Windows.Forms.TextBox();
            this.WeightsTextBox = new System.Windows.Forms.TextBox();
            this.NamesTXTTextBox = new System.Windows.Forms.TextBox();
            this.OutputModelTextBox = new System.Windows.Forms.TextBox();
            this.DarknetTextBox = new System.Windows.Forms.TextBox();
            this.DarknetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightsPathButton
            // 
            this.WeightsPathButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeightsPathButton.FlatAppearance.BorderSize = 0;
            this.WeightsPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeightsPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WeightsPathButton.Location = new System.Drawing.Point(15, 320);
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
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "WeightsPath";
            // 
            // ModelPath
            // 
            this.ModelPath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModelPath.FlatAppearance.BorderSize = 0;
            this.ModelPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ModelPath.Location = new System.Drawing.Point(377, 324);
            this.ModelPath.Name = "ModelPath";
            this.ModelPath.Size = new System.Drawing.Size(123, 34);
            this.ModelPath.TabIndex = 22;
            this.ModelPath.Text = "OutputModelPath";
            this.ModelPath.UseVisualStyleBackColor = false;
            this.ModelPath.Click += new System.EventHandler(this.ModelPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(374, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "OutputModelPath";
            // 
            // TrainPhotosPathButton
            // 
            this.TrainPhotosPathButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrainPhotosPathButton.FlatAppearance.BorderSize = 0;
            this.TrainPhotosPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainPhotosPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TrainPhotosPathButton.Location = new System.Drawing.Point(15, 203);
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
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "TrainPhotos (with .txts!)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Yolo-custom.cfg";
            // 
            // PathToCfgButton
            // 
            this.PathToCfgButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PathToCfgButton.FlatAppearance.BorderSize = 0;
            this.PathToCfgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathToCfgButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PathToCfgButton.Location = new System.Drawing.Point(15, 82);
            this.PathToCfgButton.Name = "PathToCfgButton";
            this.PathToCfgButton.Size = new System.Drawing.Size(123, 34);
            this.PathToCfgButton.TabIndex = 27;
            this.PathToCfgButton.Text = "PathToCFG";
            this.PathToCfgButton.UseVisualStyleBackColor = false;
            this.PathToCfgButton.Click += new System.EventHandler(this.PathToCfgButton_Click);
            // 
            // NamesTXTButton
            // 
            this.NamesTXTButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NamesTXTButton.FlatAppearance.BorderSize = 0;
            this.NamesTXTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NamesTXTButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NamesTXTButton.Location = new System.Drawing.Point(377, 81);
            this.NamesTXTButton.Name = "NamesTXTButton";
            this.NamesTXTButton.Size = new System.Drawing.Size(137, 35);
            this.NamesTXTButton.TabIndex = 33;
            this.NamesTXTButton.Text = "Path to TXT with names";
            this.NamesTXTButton.UseVisualStyleBackColor = false;
            this.NamesTXTButton.Click += new System.EventHandler(this.NamesTXTButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(374, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "NamesTxtPath";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SubmitButton.Location = new System.Drawing.Point(0, 375);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(729, 77);
            this.SubmitButton.TabIndex = 34;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CFGTextBox
            // 
            this.CFGTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CFGTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CFGTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CFGTextBox.Location = new System.Drawing.Point(15, 44);
            this.CFGTextBox.Name = "CFGTextBox";
            this.CFGTextBox.ReadOnly = true;
            this.CFGTextBox.Size = new System.Drawing.Size(339, 20);
            this.CFGTextBox.TabIndex = 35;
            // 
            // TrainPhotosTextBox
            // 
            this.TrainPhotosTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrainPhotosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrainPhotosTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TrainPhotosTextBox.Location = new System.Drawing.Point(15, 162);
            this.TrainPhotosTextBox.Name = "TrainPhotosTextBox";
            this.TrainPhotosTextBox.ReadOnly = true;
            this.TrainPhotosTextBox.Size = new System.Drawing.Size(339, 20);
            this.TrainPhotosTextBox.TabIndex = 36;
            // 
            // WeightsTextBox
            // 
            this.WeightsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeightsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WeightsTextBox.Location = new System.Drawing.Point(15, 283);
            this.WeightsTextBox.Name = "WeightsTextBox";
            this.WeightsTextBox.ReadOnly = true;
            this.WeightsTextBox.Size = new System.Drawing.Size(339, 20);
            this.WeightsTextBox.TabIndex = 37;
            // 
            // NamesTXTTextBox
            // 
            this.NamesTXTTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NamesTXTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamesTXTTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NamesTXTTextBox.Location = new System.Drawing.Point(377, 44);
            this.NamesTXTTextBox.Name = "NamesTXTTextBox";
            this.NamesTXTTextBox.ReadOnly = true;
            this.NamesTXTTextBox.Size = new System.Drawing.Size(339, 20);
            this.NamesTXTTextBox.TabIndex = 38;
            // 
            // OutputModelTextBox
            // 
            this.OutputModelTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputModelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OutputModelTextBox.Location = new System.Drawing.Point(377, 283);
            this.OutputModelTextBox.Name = "OutputModelTextBox";
            this.OutputModelTextBox.ReadOnly = true;
            this.OutputModelTextBox.Size = new System.Drawing.Size(339, 20);
            this.OutputModelTextBox.TabIndex = 39;
            // 
            // DarknetTextBox
            // 
            this.DarknetTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DarknetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DarknetTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DarknetTextBox.Location = new System.Drawing.Point(377, 162);
            this.DarknetTextBox.Name = "DarknetTextBox";
            this.DarknetTextBox.ReadOnly = true;
            this.DarknetTextBox.Size = new System.Drawing.Size(339, 20);
            this.DarknetTextBox.TabIndex = 42;
            // 
            // DarknetButton
            // 
            this.DarknetButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DarknetButton.FlatAppearance.BorderSize = 0;
            this.DarknetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarknetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DarknetButton.Location = new System.Drawing.Point(377, 199);
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
            this.label3.Location = new System.Drawing.Point(374, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Yolov4Path";
            // 
            // PathWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(729, 452);
            this.Controls.Add(this.DarknetTextBox);
            this.Controls.Add(this.DarknetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputModelTextBox);
            this.Controls.Add(this.NamesTXTTextBox);
            this.Controls.Add(this.WeightsTextBox);
            this.Controls.Add(this.TrainPhotosTextBox);
            this.Controls.Add(this.CFGTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NamesTXTButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PathToCfgButton);
            this.Controls.Add(this.WeightsPathButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ModelPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TrainPhotosPathButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathWindow";
            this.Text = "PathWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WeightsPathButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ModelPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TrainPhotosPathButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PathToCfgButton;
        private System.Windows.Forms.Button NamesTXTButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox CFGTextBox;
        private System.Windows.Forms.TextBox TrainPhotosTextBox;
        private System.Windows.Forms.TextBox WeightsTextBox;
        private System.Windows.Forms.TextBox NamesTXTTextBox;
        private System.Windows.Forms.TextBox OutputModelTextBox;
        private System.Windows.Forms.TextBox DarknetTextBox;
        private System.Windows.Forms.Button DarknetButton;
        private System.Windows.Forms.Label label3;
    }
}