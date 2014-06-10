using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace DelayStartup
{
    public partial class FormStartup : Form
    {
        

        public FormStartup()
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 0)
            {
                argSleepDelay = Convert.ToInt32(args[1]);
                argAppString = args[2];
            }
            InitializeComponent();
        }

        private int argSleepDelay;
        private string argAppString;
        private int timmerCount;

        private void FormStartup_Load(object sender, EventArgs e)
        {
            //get arg for command line
            //for debug and programing 
            
            //argSleepDelay = 30;
            //argAppString = "c:\\windows\\notepad.exe";

            //display args in form
            int appNameStart = argAppString.LastIndexOf('\\') + 1;
            int appNameEnd = argAppString.LastIndexOf('.');
            string appName = argAppString.Substring(appNameStart, (appNameEnd - appNameStart));
            appName = appName.Substring(0, 1).ToUpper() + appName.Substring(1).ToLower();
            lblProgramName.Text = appName;
            this.Text = appName;
            lblCountDown.Text = argSleepDelay.ToString();

            //load icon into form icon
            Icon ico = Icon.ExtractAssociatedIcon(argAppString);
            this.Icon = ico;

            //loads icon of exe into picbox
            //picboxIcon.Image = ico.ToBitmap();
            picboxIcon.BackgroundImage = ico.ToBitmap();
            //picboxIcon.ImageLocation = argAppString;

            //backgorund worker

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = argSleepDelay; i >= 0; i--)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    double p = (double)i / (double)argSleepDelay;
                    int progress = Convert.ToInt32((Math.Abs(p - 1)) * 100);
                    timmerCount = i;
                    worker.ReportProgress(progress);
                }

            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCountDown.Text = timmerCount.ToString();
            if (timmerCount < 6)
                lblCountDown.ForeColor = Color.Red;
            progressBarCountDown.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                //cancell
            }

            else if (!(e.Error == null))
            {
                //error
            }

            else
            {
                //start app
                startApp();
            }
        }

        private void btLaunchNow_Click(object sender, EventArgs e)
        {
            startApp();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startApp()
        {
            Process.Start(argAppString);
            this.Close();
        }

    }
}
