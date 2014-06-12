using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Shell32;
using System.Diagnostics;
using System.IO;


namespace Delay_Startup_Timer
{
    class LinkMaster
    {
        public string CreatLink(string appName, int appDelayTime, string appLocationName)
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

            return lnkStartupPath;
        }

        public List<LinkType> LoadLinksFromStartup()
        {
            DirectoryInfo di = new DirectoryInfo(GetStartupPath());
            FileInfo[] files = di.GetFiles("*DelayStartup.lnk");
            List<LinkType> listOfLinks = new List<LinkType>();

            foreach (FileInfo fi in files) {
                //parse link into string
                string pathOnly = Path.GetDirectoryName(fi.FullName);
                string filenameOnly = Path.GetFileName(fi.FullName);

                Shell32.Shell shell = new Shell32.ShellClass();
                Shell32.Folder folder = shell.NameSpace(pathOnly);
                Shell32.FolderItem folderItem = folder.ParseName(filenameOnly);

                if (folderItem != null)
                {
                    Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                    LinkType a = new LinkType();
                    a.Arguments = link.Arguments;

                    listOfLinks.Add(a);
                }
            }
            return listOfLinks;

        }
        public void EditLink()
        { }
        public void DeleteLink()
        {
        
        }
        public string GetStartupPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Startup);        
        }
    }
    public class LinkType
    {
        public string Arguments;
        public override string ToString()
        {
            return Arguments;
        }
    }

}
