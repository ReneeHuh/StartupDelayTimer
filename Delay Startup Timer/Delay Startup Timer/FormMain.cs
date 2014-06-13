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
                listBoxMain.Items.Add(element);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ListBoxMainRefresh();
        }


        private void btCreate_Click(object sender, EventArgs e)
        {
            FormCreateLink myForm = new FormCreateLink();
            myForm.ShowDialog();
            ListBoxMainRefresh();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (listBoxMain.SelectedIndex != -1)
            {
                LinkType test = new LinkType();
                test = (LinkType)listBoxMain.SelectedItem;

                FormEditLink myEdit = new FormEditLink();
                myEdit.Edit = test;
                myEdit.ShowDialog();

                ListBoxMainRefresh();
            }
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            if (listBoxMain.SelectedIndex != -1)
            {
                LinkType test = new LinkType();
                test = (LinkType)listBoxMain.SelectedItem;
                Process.Start(test.Target,test.Arguments);

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMain.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you want to delete this DelayStartup App", "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    LinkMaster myDel = new LinkMaster();
                    myDel.DeleteLink((LinkType)listBoxMain.SelectedItem);
                }
            }
            ListBoxMainRefresh();
        }

        private void btOpenStartupPath_Click(object sender, EventArgs e)
        {
            LinkMaster myLink = new LinkMaster();
            Process.Start(myLink.GetStartupPath());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
