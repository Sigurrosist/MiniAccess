namespace prjMiniAccess
{
    partial class frmTitle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.tmrTitle = new System.Windows.Forms.Timer(this.components);
            this.prgLoad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tmrTitle
            // 
            this.tmrTitle.Enabled = true;
            this.tmrTitle.Interval = 30;
            this.tmrTitle.Tick += new System.EventHandler(this.tmrTitle_Tick);
            // 
            // prgLoad
            // 
            this.prgLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prgLoad.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.prgLoad.Location = new System.Drawing.Point(52, 356);
            this.prgLoad.Name = "prgLoad";
            this.prgLoad.Size = new System.Drawing.Size(502, 12);
            this.prgLoad.TabIndex = 0;
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 380);
            this.Controls.Add(this.prgLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTitle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTitle";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTitle;
        private System.Windows.Forms.ProgressBar prgLoad;
    }
}