
namespace TrainYolov4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrainingOutput = new System.Windows.Forms.RichTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.StopTrainingButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConfigurePathsButton = new System.Windows.Forms.Button();
            this.ConfigureCfgButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TrainButton = new System.Windows.Forms.Button();
            this.GenerateCFGButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrainingOutput
            // 
            this.TrainingOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrainingOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrainingOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainingOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TrainingOutput.Location = new System.Drawing.Point(0, 0);
            this.TrainingOutput.Name = "TrainingOutput";
            this.TrainingOutput.ReadOnly = true;
            this.TrainingOutput.Size = new System.Drawing.Size(417, 384);
            this.TrainingOutput.TabIndex = 4;
            this.TrainingOutput.TabStop = false;
            this.TrainingOutput.Text = "";
            this.TrainingOutput.TextChanged += new System.EventHandler(this.TrainingOutput_TextChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer.Panel1.Controls.Add(this.StopTrainingButton);
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.TrainingOutput);
            this.splitContainer.Size = new System.Drawing.Size(771, 384);
            this.splitContainer.SplitterDistance = 350;
            this.splitContainer.TabIndex = 5;
            this.splitContainer.TabStop = false;
            // 
            // StopTrainingButton
            // 
            this.StopTrainingButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopTrainingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StopTrainingButton.Enabled = false;
            this.StopTrainingButton.FlatAppearance.BorderSize = 0;
            this.StopTrainingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopTrainingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopTrainingButton.Location = new System.Drawing.Point(0, 313);
            this.StopTrainingButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopTrainingButton.Name = "StopTrainingButton";
            this.StopTrainingButton.Size = new System.Drawing.Size(350, 71);
            this.StopTrainingButton.TabIndex = 13;
            this.StopTrainingButton.TabStop = false;
            this.StopTrainingButton.Text = "StopTraining";
            this.StopTrainingButton.UseVisualStyleBackColor = false;
            this.StopTrainingButton.Click += new System.EventHandler(this.StopTrainingButton_Click);
            this.StopTrainingButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.StopTrainingButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ConfigurePathsButton);
            this.panel2.Controls.Add(this.ConfigureCfgButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 100);
            this.panel2.TabIndex = 15;
            // 
            // ConfigurePathsButton
            // 
            this.ConfigurePathsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfigurePathsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConfigurePathsButton.FlatAppearance.BorderSize = 0;
            this.ConfigurePathsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigurePathsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfigurePathsButton.Location = new System.Drawing.Point(0, 0);
            this.ConfigurePathsButton.Name = "ConfigurePathsButton";
            this.ConfigurePathsButton.Size = new System.Drawing.Size(173, 100);
            this.ConfigurePathsButton.TabIndex = 10;
            this.ConfigurePathsButton.TabStop = false;
            this.ConfigurePathsButton.Text = "Configure Paths";
            this.ConfigurePathsButton.UseVisualStyleBackColor = false;
            this.ConfigurePathsButton.Click += new System.EventHandler(this.ConfigurePathsButton_Click);
            this.ConfigurePathsButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.ConfigurePathsButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // ConfigureCfgButton
            // 
            this.ConfigureCfgButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfigureCfgButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConfigureCfgButton.FlatAppearance.BorderSize = 0;
            this.ConfigureCfgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigureCfgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfigureCfgButton.Location = new System.Drawing.Point(177, 0);
            this.ConfigureCfgButton.Name = "ConfigureCfgButton";
            this.ConfigureCfgButton.Size = new System.Drawing.Size(173, 100);
            this.ConfigureCfgButton.TabIndex = 11;
            this.ConfigureCfgButton.TabStop = false;
            this.ConfigureCfgButton.Text = "Configure cfg";
            this.ConfigureCfgButton.UseVisualStyleBackColor = false;
            this.ConfigureCfgButton.Click += new System.EventHandler(this.ConfigureCfgButton_Click);
            this.ConfigureCfgButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.ConfigureCfgButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TrainButton);
            this.panel1.Controls.Add(this.GenerateCFGButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 100);
            this.panel1.TabIndex = 14;
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrainButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.TrainButton.Enabled = false;
            this.TrainButton.FlatAppearance.BorderSize = 0;
            this.TrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrainButton.Location = new System.Drawing.Point(0, 0);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(173, 100);
            this.TrainButton.TabIndex = 9;
            this.TrainButton.TabStop = false;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            this.TrainButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.TrainButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // GenerateCFGButton
            // 
            this.GenerateCFGButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateCFGButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GenerateCFGButton.FlatAppearance.BorderSize = 0;
            this.GenerateCFGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateCFGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateCFGButton.Location = new System.Drawing.Point(177, 0);
            this.GenerateCFGButton.Name = "GenerateCFGButton";
            this.GenerateCFGButton.Size = new System.Drawing.Size(173, 100);
            this.GenerateCFGButton.TabIndex = 3;
            this.GenerateCFGButton.TabStop = false;
            this.GenerateCFGButton.Text = "GenerateCFG";
            this.GenerateCFGButton.UseVisualStyleBackColor = false;
            this.GenerateCFGButton.Click += new System.EventHandler(this.GenerateCFGButton_Click);
            this.GenerateCFGButton.MouseEnter += new System.EventHandler(this.HoverOn);
            this.GenerateCFGButton.MouseLeave += new System.EventHandler(this.HoverOff);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 106);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yolov4 Trainer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 384);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TrainYolov4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox TrainingOutput;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopTrainingButton;
        private System.Windows.Forms.Button ConfigureCfgButton;
        private System.Windows.Forms.Button ConfigurePathsButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button GenerateCFGButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

