using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Delay_Startup_Timer
{
    public partial class FormCreateLink : Form
    {
        string appLocationName;
        string appName;
        bool appReady = false;
        int appDelayTime;


        public FormCreateLink()
        {
            InitializeComponent();
        }

        private void FormCreateLink_Load(object sender, EventArgs e)
        {
            LoadDefaultSettings();
            UserInterfaceEnable(false);
        }

        private void LoadDefaultSettings()
        {
            lblStep1.Text = "";
            updownDelayTime.Value = Properties.Settings.Default.DefaultDelayTime;
        }

        private void UserInterfaceEnable(bool set)
        {
            if (set == true)
            {
                //Enabled interface
                updownDelayTime.Enabled = true;
                btCreateStartUp.Enabled = true;

            }
            else
            { 
                //disable interface
                updownDelayTime.Enabled = false;
                btCreateStartUp.Enabled = false;
            }
        }

        private void btSelectApp_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Executables Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (openFileDialog1.SafeFileName != null)
                {
                    //get file and location
                    appLocationName = openFileDialog1.FileName;

                    //set shortened app name
                    appName = openFileDialog1.SafeFileName;
                    appName = appName.Substring(0, 1).ToUpper() + appName.Substring(1).ToLower();

                    lblStep1.Text = appName;

                    //set icon
                    try
                    {
                        Icon ico = Icon.ExtractAssociatedIcon(appLocationName);
                        picboxIcon.Image = ico.ToBitmap();
                    }
                    catch
                    {
                        //do nothing
                    }

                    //set ready
                    appReady = true;

                    //set user interface to enable
                    UserInterfaceEnable(true);
                }
            }
        }

        private void btCreateStartUp_Click(object sender, EventArgs e)
        {
            if (appReady == true)
            {

                LinkMaster myLink = new LinkMaster();
                string lnkStartupPath = myLink.CreatLink(appName, appDelayTime, appLocationName);
                
                ////message Box
                //if (MessageBox.Show("The DelayTimer has been added, Would you like run the App", "Do you want to test Delaytimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                //{ 
                //    //if click yes Run app
                //    Process.Start(lnkStartupPath);
                //}
                ////close app
                this.Close();
            }
            else
            {
                //do nothing
            }
        }

        private void updownDelayTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                appDelayTime = (int)updownDelayTime.Value;
            }
            catch
            {
                MessageBox.Show("Please enter a number for Delay Time");
            }

        }
    }
}
