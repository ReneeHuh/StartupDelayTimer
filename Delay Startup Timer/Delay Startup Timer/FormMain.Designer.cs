namespace Delay_Startup_Timer
{
    partial class FormMain
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
            this.btCreateStartUp = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btSelectApp = new System.Windows.Forms.Button();
            this.updownDelayTime = new System.Windows.Forms.NumericUpDown();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblstep3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updownDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btCreateStartUp
            // 
            this.btCreateStartUp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateStartUp.Location = new System.Drawing.Point(13, 258);
            this.btCreateStartUp.Margin = new System.Windows.Forms.Padding(4);
            this.btCreateStartUp.Name = "btCreateStartUp";
            this.btCreateStartUp.Size = new System.Drawing.Size(296, 58);
            this.btCreateStartUp.TabIndex = 0;
            this.btCreateStartUp.Text = "Create Start Up";
            this.btCreateStartUp.UseVisualStyleBackColor = true;
            this.btCreateStartUp.Click += new System.EventHandler(this.btCreateStartUp_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(16, 214);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Delay Time:";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(16, 111);
            this.lblApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(124, 19);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "Application Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btSelectApp
            // 
            this.btSelectApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectApp.Location = new System.Drawing.Point(164, 111);
            this.btSelectApp.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectApp.Name = "btSelectApp";
            this.btSelectApp.Size = new System.Drawing.Size(148, 53);
            this.btSelectApp.TabIndex = 3;
            this.btSelectApp.Text = "Select App";
            this.btSelectApp.UseVisualStyleBackColor = true;
            this.btSelectApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // updownDelayTime
            // 
            this.updownDelayTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownDelayTime.Location = new System.Drawing.Point(128, 212);
            this.updownDelayTime.Margin = new System.Windows.Forms.Padding(4);
            this.updownDelayTime.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.updownDelayTime.Name = "updownDelayTime";
            this.updownDelayTime.Size = new System.Drawing.Size(160, 27);
            this.updownDelayTime.TabIndex = 4;
            this.updownDelayTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updownDelayTime.ValueChanged += new System.EventHandler(this.updownDelayTime_ValueChanged);
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(64, 174);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(37, 19);
            this.lblStep1.TabIndex = 5;
            this.lblStep1.Text = "????";
            // 
            // picboxIcon
            // 
            this.picboxIcon.Location = new System.Drawing.Point(13, 146);
            this.picboxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picboxIcon.Name = "picboxIcon";
            this.picboxIcon.Size = new System.Drawing.Size(43, 47);
            this.picboxIcon.TabIndex = 6;
            this.picboxIcon.TabStop = false;
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(16, 43);
            this.lblStep2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(150, 19);
            this.lblStep2.TabIndex = 7;
            this.lblStep2.Text = "Step 2 Set Delay Time";
            // 
            // lblstep3
            // 
            this.lblstep3.AutoSize = true;
            this.lblstep3.Location = new System.Drawing.Point(16, 62);
            this.lblstep3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstep3.Name = "lblstep3";
            this.lblstep3.Size = new System.Drawing.Size(203, 19);
            this.lblstep3.TabIndex = 8;
            this.lblstep3.Text = "Step 3 Create Startup Shortcut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Step 1 Location Application EXE";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstep3);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.picboxIcon);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.updownDelayTime);
            this.Controls.Add(this.btSelectApp);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btCreateStartUp);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "   Delayed Startup Creator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreateStartUp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btSelectApp;
        private System.Windows.Forms.NumericUpDown updownDelayTime;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.PictureBox picboxIcon;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblstep3;
        private System.Windows.Forms.Label label1;
    }
}