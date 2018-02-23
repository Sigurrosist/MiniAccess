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
    public partial class frmNewField : Form
    {
        public frmNewField()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFieldName.Text == null)
            {
                MessageBox.Show("Please enter the name of the new table.", "No Text");
            }
            else
            {
                frmNew fn = ((frmNew)(this.Owner)); //set the owner of this form
                fn.Field_Name = txtFieldName.Text; // set the field name string of the owner form to the text in the current form
                int index = cboDatatype.SelectedIndex;
                this.Close();
            }
        }

        

        private void frmNewField_Load(object sender, EventArgs e)
        {
            // returns 0 : string 1 : number 2 : DateTime 3: Currency 4: YesNo 5: Autonumber
            string[] dtype = { "Text", "Number", "DateTime", "Currency", "YesNo", "Autonumber" };
            cboDatatype.DataSource = dtype;

        }
    }
}
