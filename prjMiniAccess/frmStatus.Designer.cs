namespace prjMiniAccess
{
    partial class frmStatus
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
            this.lstDatabaseDetails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDatabaseDetails
            // 
            this.lstDatabaseDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDatabaseDetails.FormattingEnabled = true;
            this.lstDatabaseDetails.ItemHeight = 16;
            this.lstDatabaseDetails.Location = new System.Drawing.Point(13, 13);
            this.lstDatabaseDetails.Name = "lstDatabaseDetails";
            this.lstDatabaseDetails.Size = new System.Drawing.Size(405, 544);
            this.lstDatabaseDetails.TabIndex = 0;
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 572);
            this.Controls.Add(this.lstDatabaseDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStatus";
            this.Text = "frmStatus";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatabaseDetails;
    }
}