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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ListBoxMainRefresh()
        {
            listBoxMain.Items.Clear();
            LinkMaster myLink = new LinkMaster();
            List<LinkType> listofLinks = new List<LinkType>();
            listofLinks = myLink.LoadLinksFromStartup();
            foreach (LinkType element in listofLinks)
            {
                listBoxMain.Items.Add(element.ToString());
            }
            //http://www.codeproject.com/Articles/146757/Add-Remove-Startup-Folder-Shortcut-to-Your-App
        
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ListBoxMainRefresh();
        }


        private void btCreate_Click(object sender, EventArgs e)
        {
            FormCreateLink myForm = new FormCreateLink();
            myForm.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void btTest_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void btOpenStartupPath_Click(object sender, EventArgs e)
        {
            LinkMaster myLink = new LinkMaster();
            Process.Start(myLink.GetStartupPath());
        }
    }
}
