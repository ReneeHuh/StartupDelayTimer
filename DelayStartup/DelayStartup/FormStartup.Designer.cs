namespace DelayStartup
{
    partial class FormStartup
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
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.progressBarCountDown = new System.Windows.Forms.ProgressBar();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxCountDown = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btLaunchNow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            this.groupBoxCountDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxIcon
            // 
            this.picboxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxIcon.Location = new System.Drawing.Point(37, 33);
            this.picboxIcon.Name = "picboxIcon";
            this.picboxIcon.Size = new System.Drawing.Size(64, 64);
            this.picboxIcon.TabIndex = 10;
            this.picboxIcon.TabStop = false;
            // 
            // progressBarCountDown
            // 
            this.progressBarCountDown.Location = new System.Drawing.Point(6, 60);
            this.progressBarCountDown.Name = "progressBarCountDown";
            this.progressBarCountDown.Size = new System.Drawing.Size(103, 23);
            this.progressBarCountDown.TabIndex = 3;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCountDown.Location = new System.Drawing.Point(21, 26);
            this.lblCountDown.MaximumSize = new System.Drawing.Size(72, 32);
            this.lblCountDown.MinimumSize = new System.Drawing.Size(72, 32);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(72, 32);
            this.lblCountDown.TabIndex = 2;
            this.lblCountDown.Text = "888";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(13, 10);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(57, 18);
            this.lblProgramName.TabIndex = 9;
            this.lblProgramName.Text = "Start: ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBoxCountDown
            // 
            this.groupBoxCountDown.Controls.Add(this.progressBarCountDown);
            this.groupBoxCountDown.Controls.Add(this.lblCountDown);
            this.groupBoxCountDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCountDown.Location = new System.Drawing.Point(12, 103);
            this.groupBoxCountDown.Name = "groupBoxCountDown";
            this.groupBoxCountDown.Size = new System.Drawing.Size(115, 89);
            this.groupBoxCountDown.TabIndex = 8;
            this.groupBoxCountDown.TabStop = false;
            this.groupBoxCountDown.Text = "Start In ";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(73, 198);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(56, 47);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Stop && Close";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btLaunchNow
            // 
            this.btLaunchNow.Location = new System.Drawing.Point(10, 198);
            this.btLaunchNow.Name = "btLaunchNow";
            this.btLaunchNow.Size = new System.Drawing.Size(57, 47);
            this.btLaunchNow.TabIndex = 6;
            this.btLaunchNow.Text = "Launch Now";
            this.btLaunchNow.UseVisualStyleBackColor = true;
            this.btLaunchNow.Click += new System.EventHandler(this.btLaunchNow_Click);
            // 
            // FormStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 254);
            this.Controls.Add(this.picboxIcon);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.groupBoxCountDown);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btLaunchNow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStartup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormStartup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            this.groupBoxCountDown.ResumeLayout(false);
            this.groupBoxCountDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxIcon;
        private System.Windows.Forms.ProgressBar progressBarCountDown;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblProgramName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxCountDown;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btLaunchNow;
    }
}

