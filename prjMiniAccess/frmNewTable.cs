using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMiniAccess
{
    public partial class frmNewTable : Form
    {
        public frmNewTable()
        {
            InitializeComponent();
        }

        private void frmNewTable_Load(object sender, EventArgs e)
        {
            // loading
        }
        public string TableName
        {
            get { return txtTableName.Text; }
            set { txtTableName.Text = value; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text == null)
            {
                MessageBox.Show("Please enter the name of the new table.", "No Text");
            }
            else
            {
                frmNew fn = ((frmNew)(this.Owner)); //set the owner of this form
                fn.lblCurrentTable.Text = txtTableName.Text; // set the public label of the owner form to the text in the current form
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
