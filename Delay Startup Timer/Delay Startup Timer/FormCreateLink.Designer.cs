namespace Delay_Startup_Timer
{
    partial class FormCreateLink
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
            this.lblStep1 = new System.Windows.Forms.Label();
            this.updownDelayTime = new System.Windows.Forms.NumericUpDown();
            this.btSelectApp = new System.Windows.Forms.Button();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btCreateStartUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownDelayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxIcon
            // 
            this.picboxIcon.Location = new System.Drawing.Point(19, 157);
            this.picboxIcon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.picboxIcon.Name = "picboxIcon";
            this.picboxIcon.Size = new System.Drawing.Size(57, 69);
            this.picboxIcon.TabIndex = 16;
            this.picboxIcon.TabStop = false;
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(87, 176);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(37, 19);
            this.lblStep1.TabIndex = 15;
            this.lblStep1.Text = "????";
            // 
            // updownDelayTime
            // 
            this.updownDelayTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownDelayTime.Location = new System.Drawing.Point(137, 255);
            this.updownDelayTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.updownDelayTime.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.updownDelayTime.Name = "updownDelayTime";
            this.updownDelayTime.Size = new System.Drawing.Size(101, 27);
            this.updownDelayTime.TabIndex = 14;
            this.updownDelayTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.updownDelayTime.ValueChanged += new System.EventHandler(this.updownDelayTime_ValueChanged);
            // 
            // btSelectApp
            // 
            this.btSelectApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectApp.Location = new System.Drawing.Point(55, 63);
            this.btSelectApp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btSelectApp.Name = "btSelectApp";
            this.btSelectApp.Size = new System.Drawing.Size(193, 55);
            this.btSelectApp.TabIndex = 13;
            this.btSelectApp.Text = "Select App";
            this.btSelectApp.UseVisualStyleBackColor = true;
            this.btSelectApp.Click += new System.EventHandler(this.btSelectApp_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(14, 124);
            this.lblApp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(124, 19);
            this.lblApp.TabIndex = 12;
            this.lblApp.Text = "Application Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 258);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 19);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Delay Time:";
            // 
            // btCreateStartUp
            // 
            this.btCreateStartUp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateStartUp.Location = new System.Drawing.Point(55, 307);
            this.btCreateStartUp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btCreateStartUp.Name = "btCreateStartUp";
            this.btCreateStartUp.Size = new System.Drawing.Size(193, 56);
            this.btCreateStartUp.TabIndex = 10;
            this.btCreateStartUp.Text = "Create Startup App";
            this.btCreateStartUp.UseVisualStyleBackColor = true;
            this.btCreateStartUp.Click += new System.EventHandler(this.btCreateStartUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select the Application \r\nOr Document To Be Started";
            // 
            // FormCreateLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxIcon);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.updownDelayTime);
            this.Controls.Add(this.btSelectApp);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btCreateStartUp);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCreateLink";
            this.Text = "Create Link";
            this.Load += new System.EventHandler(this.FormCreateLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownDelayTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxIcon;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.NumericUpDown updownDelayTime;
        private System.Windows.Forms.Button btSelectApp;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btCreateStartUp;
        private System.Windows.Forms.Label label1;
    }
}