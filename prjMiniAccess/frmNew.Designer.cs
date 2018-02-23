namespace prjMiniAccess
{
    partial class frmNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTable = new System.Windows.Forms.Button();
            this.btnField = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstview_current_table = new System.Windows.Forms.ListView();
            this.ind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentTable = new System.Windows.Forms.Label();
            this.btnPreviousTable = new System.Windows.Forms.Button();
            this.btnNextTable = new System.Windows.Forms.Button();
            this.lstCurrent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTable
            // 
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTable.Location = new System.Drawing.Point(-1, -1);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(185, 120);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "New Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnField
            // 
            this.btnField.FlatAppearance.BorderSize = 0;
            this.btnField.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnField.Location = new System.Drawing.Point(-1, 125);
            this.btnField.Name = "btnField";
            this.btnField.Size = new System.Drawing.Size(185, 120);
            this.btnField.TabIndex = 1;
            this.btnField.Text = "New Field";
            this.btnField.UseVisualStyleBackColor = true;
            this.btnField.Click += new System.EventHandler(this.btnField_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(-1, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 120);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstview_current_table
            // 
            this.lstview_current_table.BackColor = System.Drawing.Color.MintCream;
            this.lstview_current_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstview_current_table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ind,
            this.FieldName,
            this.DataType});
            this.lstview_current_table.GridLines = true;
            this.lstview_current_table.Location = new System.Drawing.Point(201, 88);
            this.lstview_current_table.Name = "lstview_current_table";
            this.lstview_current_table.Size = new System.Drawing.Size(499, 385);
            this.lstview_current_table.TabIndex = 3;
            this.lstview_current_table.UseCompatibleStateImageBehavior = false;
            this.lstview_current_table.View = System.Windows.Forms.View.Details;
            // 
            // ind
            // 
            this.ind.Text = "";
            this.ind.Width = 100;
            // 
            // FieldName
            // 
            this.FieldName.Text = "Field Name";
            this.FieldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FieldName.Width = 200;
            // 
            // DataType
            // 
            this.DataType.Text = "Data Type";
            this.DataType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataType.Width = 200;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(-1, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 120);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Table : ";
            // 
            // lblCurrentTable
            // 
            this.lblCurrentTable.AutoSize = true;
            this.lblCurrentTable.Location = new System.Drawing.Point(451, 35);
            this.lblCurrentTable.Name = "lblCurrentTable";
            this.lblCurrentTable.Size = new System.Drawing.Size(0, 21);
            this.lblCurrentTable.TabIndex = 6;
            // 
            // btnPreviousTable
            // 
            this.btnPreviousTable.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPreviousTable.FlatAppearance.BorderSize = 0;
            this.btnPreviousTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPreviousTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousTable.ForeColor = System.Drawing.Color.Black;
            this.btnPreviousTable.Location = new System.Drawing.Point(201, 28);
            this.btnPreviousTable.Name = "btnPreviousTable";
            this.btnPreviousTable.Size = new System.Drawing.Size(100, 34);
            this.btnPreviousTable.TabIndex = 7;
            this.btnPreviousTable.Text = "Previous";
            this.btnPreviousTable.UseVisualStyleBackColor = false;
            // 
            // btnNextTable
            // 
            this.btnNextTable.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNextTable.FlatAppearance.BorderSize = 0;
            this.btnNextTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNextTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTable.ForeColor = System.Drawing.Color.Black;
            this.btnNextTable.Location = new System.Drawing.Point(595, 28);
            this.btnNextTable.Name = "btnNextTable";
            this.btnNextTable.Size = new System.Drawing.Size(105, 34);
            this.btnNextTable.TabIndex = 8;
            this.btnNextTable.Text = "Next";
            this.btnNextTable.UseVisualStyleBackColor = false;
            // 
            // lstCurrent
            // 
            this.lstCurrent.FormattingEnabled = true;
            this.lstCurrent.ItemHeight = 21;
            this.lstCurrent.Location = new System.Drawing.Point(730, 28);
            this.lstCurrent.Name = "lstCurrent";
            this.lstCurrent.Size = new System.Drawing.Size(383, 445);
            this.lstCurrent.TabIndex = 9;
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1147, 505);
            this.Controls.Add(this.lstCurrent);
            this.Controls.Add(this.btnNextTable);
            this.Controls.Add(this.btnPreviousTable);
            this.Controls.Add(this.lblCurrentTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstview_current_table);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnField);
            this.Controls.Add(this.btnTable);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNew";
            this.Text = "frmNew";
            this.Load += new System.EventHandler(this.frmNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnField;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstview_current_table;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreviousTable;
        private System.Windows.Forms.Button btnNextTable;
        private System.Windows.Forms.ListBox lstCurrent;
        public System.Windows.Forms.Label lblCurrentTable;
        private System.Windows.Forms.ColumnHeader ind;
        private System.Windows.Forms.ColumnHeader FieldName;
        private System.Windows.Forms.ColumnHeader DataType;
    }
}