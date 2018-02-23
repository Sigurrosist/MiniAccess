using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DAO;
using System.IO;

namespace prjMiniAccess
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Thread trdSplash = new Thread(strSplash);
            trdSplash.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            trdSplash.Abort();
        }

        private void strSplash()
        {
            frmTitle splash = new frmTitle();
            Application.Run(splash);
        }
        private void quit()
        {
            if (MessageBox.Show("Do you want to quit the application?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            quit();
        }

        frmNew fn = null;
        string filepath = "";
        public string Filepath_main
        {
            get { return filepath; }
            set { filepath = value; }
        }
        private void Fn_FormClosed(object sender, FormClosedEventArgs e)
        {
            fn = null;
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            if (fn == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Access Database File|*.accdb";
                sfd.FileName = "New 1";
                sfd.Title = "Save the Access Database File";
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    filepath = sfd.FileName;
                    frmNew fn = new frmNew();
                    fn.MdiParent = this;
                    ((frmNew)fn).Text = Path.GetFileNameWithoutExtension(sfd.FileName);
                    fn.Filepath_new = Filepath_main;
                    fn.FormClosed += Fn_FormClosed;
                    fn.Show();

                }
            }
            else
            {
                fn.Activate();
            }
        }
    }
}


