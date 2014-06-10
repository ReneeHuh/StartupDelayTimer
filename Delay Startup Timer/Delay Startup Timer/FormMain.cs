using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Diagnostics;

namespace Delay_Startup_Timer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        string appLocationName;
        string appName;
        bool appReady = false;
        int appDelayTime;

        private void FormMain_Load(object sender, EventArgs e)
        {

            lblStep1.Text = " ";
            appDelayTime = Properties.Settings.Default.DelayTime;
            updownDelayTime.Value = Properties.Settings.Default.DelayTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult ();
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
                }
            }

        }

        private void updownDelayTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                appDelayTime = Convert.ToInt32(updownDelayTime.Value);
            }
            catch 
            { 
                
            }
        }

        private void btCreateStartUp_Click(object sender, EventArgs e)
        {
            if (appReady == true)
            {

                //via reg keys

                //Microsoft.Win32.RegistryKey startupkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                //string command = Application.ExecutablePath + " " + appDelayTime + " " + appLocationName;
                //startupkey.SetValue(appName, command);

                //via short cut
                WshShellClass wshShell = new WshShellClass();
                IWshRuntimeLibrary.IWshShortcut myShortcut;

                string lnkStartupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                //string lnkStartupPath = "c:\\";
                string lnkFileName = "\\" + appName + "_DelayStartup" + ".lnk";

                //sets lnk path and name
                myShortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(lnkStartupPath + lnkFileName);

                //sets targets path and name
                //myShortcut.TargetPath = Application.ExecutablePath;
                myShortcut.TargetPath = Environment.CurrentDirectory + "\\" + "DelayStartup.exe";

                //working directory ???
                myShortcut.WorkingDirectory = Application.StartupPath;

                //arguments "\"" need for unc with spaces
                myShortcut.Arguments = " " + "\"" + appDelayTime + "\"" + " " + "\"" + appLocationName + "\"";

                //Desription
                myShortcut.Description = " delayed startup for " + appName;

                //set icon 
                //myShortcut.IconLocation = Application.StartupPath + @"\App.ico";

                //save lnk
                myShortcut.Save();

                //message Box
                MessageBox.Show("You App Has been Added");

                //clear 
                lblStep1.Text = " ";
                picboxIcon.Image = null;

                //open directory
                Process.Start(lnkStartupPath);
            }
            else 
            {
                //do nothing
            }

        }

        
    }
}
