using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace prjMiniAccess
{
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }

        private void tmrTitle_Tick(object sender, EventArgs e)
        {
            prgLoad.Increment(1);
            if(prgLoad.Value == 100)
            {
                tmrTitle.Stop();
            }
        }
    }
}
