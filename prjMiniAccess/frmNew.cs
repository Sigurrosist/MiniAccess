using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace prjMiniAccess
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }
        frmNewTable nt;
        private void btnTable_Click(object sender, EventArgs e)
        {
            if (nt == null)
            {
                nt = new frmNewTable();
                nt.Owner = this;
                nt.FormClosed += Nt_FormClosed;
                nt.Show();
            }
            else
            {
                nt.Activate();
            }

        }
        Database myDB;
        TableDef myTB;
        Field myFL;
        frmNewField nf;
        string fieldname;
        int fieldtype;
        int fieldindex;
        string filepath;
        string frmname;
        bool primary = false;
        public string Frm_Name
        {
            get { return frmname; }
            set { frmname = value; }
        }

        public string Field_Name
        {
            get { return fieldname; }
            set { fieldname = value; }
        }
        public string Filepath_new
        {
            get { return filepath; }
            set { filepath = value; }
        }
        public int Field_Type // returns 0 : string 1 : number 2 : DateTime 3: Currency 4: YesNo 5: Autonumber
        {
            get { return fieldtype; }
            set { fieldtype = value; }
        }

        private void Nt_FormClosed(object sender, FormClosedEventArgs e)
        { 
            nt = null;
            if (lblCurrentTable.Text != null)
            {
                primary = false;
                frmMain fm = ((frmMain)(this.Owner));
                myTB = myDB.CreateTableDef(lblCurrentTable.Text);
                nf = new frmNewField();
                nf.Owner = this;
                nf.FormClosed += Nf_FormClosed;
                nf.Show();
            }
        }

        private void save_new_field()
        {
            ListViewItem to_add;
            string datatype = "";
            string index = "";
            nf = null;
            MessageBox.Show(fieldtype + " is the datatype");
            switch (fieldtype)
            {
                case 0:
                    myFL = myTB.CreateField(Field_Name, DataTypeEnum.dbText, 100);
                    datatype = "Text";
                    myTB.Fields.Append(myFL);
                    break;
                case 1:
                    myFL = myTB.CreateField(Field_Name, DataTypeEnum.dbLong);
                    datatype = "Number";
                    myTB.Fields.Append(myFL);
                    break;
                case 2:
                    myFL = myTB.CreateField(Field_Name, DataTypeEnum.dbDate);
                    datatype = "DateTime";
                    myTB.Fields.Append(myFL);
                    break;
                case 3:
                    myFL = myTB.CreateField(Field_Name, DataTypeEnum.dbCurrency);
                    datatype = "Currency";
                    myTB.Fields.Append(myFL);
                    break;
                case 4:
                    myFL = myTB.CreateField(Field_Name, DataTypeEnum.dbBoolean);
                    datatype = "YesNo";
                    myTB.Fields.Append(myFL);
                    break;
                case 5:
                    myFL = myTB.CreateField(Field_Name, DataTypeEnum.dbLong);
                    datatype = "AutoNumber";
                    myTB.Fields.Append(myFL);
                    myFL.Attributes = (int)FieldAttributeEnum.dbAutoIncrField;
                    break;
            }
            if (!primary)
            {
                if (MessageBox.Show("Is this primary key?", "Index", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Index myInd = myTB.CreateIndex("PrimaryKey");
                    myFL = myInd.CreateField(Field_Name);
                    ((IndexFields)myInd.Fields).Append(myFL);
                    myInd.Primary = true;
                    myTB.Indexes.Append(myInd);
                    index = "Primary";
                    primary = true;
                }
            }
            to_add = new ListViewItem(index);
            to_add.SubItems.Add(Field_Name);
            to_add.SubItems.Add(datatype);
            lstview_current_table.Items.Add(to_add);
        }

        private void Nf_FormClosed(object sender, FormClosedEventArgs e)
        {
            save_new_field();        
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            DBEngine dbe = new DBEngine();
            myDB = dbe.CreateDatabase(Filepath_new, LanguageConstants.dbLangGeneral);
            this.Name = frmname;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save database and close this form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                myDB.TableDefs.Append(myTB); 
                myDB.Close();
                this.Close();
            }
        }

        private void btnField_Click(object sender, EventArgs e)
        {
            nf = new frmNewField();
            nf.Owner = this;
            nf.FormClosed += Nf_FormClosed;
            nf.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myDB.TableDefs.Append(myTB);
            MessageBox.Show("Current Table is saved with its fields","Save");
        }
    }
}
