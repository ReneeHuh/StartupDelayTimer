using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Shell32;
using System.Diagnostics;
using System.IO;
using System.Drawing;


namespace Delay_Startup_Timer
{
    class LinkMaster
    {
        //http://www.codeproject.com/Articles/146757/Add-Remove-Startup-Folder-Shortcut-to-Your-App

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
            string IconFileLocaiton = CreateIconFile(appLocationName);
            myShortcut.IconLocation = IconFileLocaiton;

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
                    LinkType a = new LinkType(link,fi);
                    listOfLinks.Add(a);
                }
            }
            return listOfLinks;

        }
        public void EditLink(LinkType EditLink)
        {
            
            //Delete
            DeleteLink(EditLink);
            //Create
            CreatLink(ParseAppName(EditLink), ParseDelayTime(EditLink), ParseAppLocaion(EditLink));
        }
        public void DeleteLink(LinkType DeleteMe)
        {
            try
            {
                System.IO.File.Delete(DeleteMe.LinkFullName);
            }
            catch
            { }
            
        }
        private string CreateIconFile(string file)
        {
            try
            {
                string appNameIcon = PraseStringLastIndexOf("\\", ".", file);
                string iconFullName = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + appNameIcon + ".ico";

                Icon ico = Icon.ExtractAssociatedIcon(file);

                System.IO.FileStream fs = new System.IO.FileStream(iconFullName, System.IO.FileMode.OpenOrCreate);
                ico.Save(fs);
                fs.Close();

                return iconFullName;
            }
            catch
            {
                //do nothing
            }
            return "";
        }

        public string GetStartupPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Startup);        
        }
        public int ParseDelayTime(LinkType Input)
        {
            //{ "60" "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"}
            int Start = Input.Arguments.IndexOf("\"") + 1 ;
            int end = Input.Arguments.IndexOf("\"",Start + 1);
            int lenght = end - Start;
            string time = Input.Arguments.Substring(Start, lenght);
            return Convert.ToInt32(time);
        }
        public string ParseAppLocaion(LinkType Input)
        {
            int End = Input.Arguments.LastIndexOf("\"");
            int Start = Input.Arguments.LastIndexOf("\"", End - 1) + 1;
            int lenght = End - Start;
            return Input.Arguments.Substring(Start,lenght);
        }
        public string ParseAppName(LinkType Input)
        {
            int Start = Input.Arguments.LastIndexOf("\\") + 1;
            int end = Input.Arguments.LastIndexOf(".");
            int lenght = end - Start;
            return Input.Arguments.Substring(Start, lenght);
        }
        public string PraseStringIndexOf(string StartingChar, string EndingChar, string InpurtString)
        {
            int start = InpurtString.IndexOf(StartingChar);
            int end = InpurtString.IndexOf(EndingChar,start +1);
            int lenght = end - start;
            string r = InpurtString.Substring(start , lenght);
            return r;
        }
        public string PraseStringLastIndexOf(string StartingChar, string EndingChar, string InpurtString)
        {
            int end = InpurtString.LastIndexOf(EndingChar);
            int start = InpurtString.LastIndexOf(StartingChar, end -1) + 1;
            if (start != -1 && end != -1)
            {
                int lenght = end - start;
                string r = InpurtString.Substring(start, lenght);
                return r;
            }
            else { return ""; }
        }
    }
    public class LinkType
    {
        public LinkType()
        { }
        public LinkType(Shell32.ShellLinkObject _Link,FileInfo _FileInfo)
        { 
            Link = _Link;
            FileInfo = _FileInfo;
            Arguments = Link.Arguments;
            WorkingDirectory = Link.WorkingDirectory;
            Description = Link.Description;
            Target = Link.Target.Path;
            LinkFullName = FileInfo.FullName;
            //Path = Link.Path;
        }
        public Shell32.ShellLinkObject Link;
        public string Arguments;
        public string WorkingDirectory;
        public string Description;
        public string Target;
        public string LinkFullName;
        public FileInfo FileInfo;
        //public string Path;

        public override string ToString()
        {
            return Arguments;
        }
    }

}
