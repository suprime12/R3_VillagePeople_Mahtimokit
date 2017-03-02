namespace R3_VillagePeople_Mahtimokit
{
    partial class Management_tab
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toimipisteetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilaushistoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakkaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toimipisteetToolStripMenuItem,
            this.varauksetToolStripMenuItem,
            this.tilaushistoriaToolStripMenuItem,
            this.asiakkaatToolStripMenuItem,
            this.ohjeetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 29);
            this.menuStrip1.TabIndex = 108;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toimipisteetToolStripMenuItem
            // 
            this.toimipisteetToolStripMenuItem.Name = "toimipisteetToolStripMenuItem";
            this.toimipisteetToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.toimipisteetToolStripMenuItem.Text = "Tietojen hallinta";
            this.toimipisteetToolStripMenuItem.Click += new System.EventHandler(this.toimipisteetToolStripMenuItem_Click);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.varauksetToolStripMenuItem.Text = "Uusi tilaus";
            this.varauksetToolStripMenuItem.Click += new System.EventHandler(this.varauksetToolStripMenuItem_Click);
            // 
            // tilaushistoriaToolStripMenuItem
            // 
            this.tilaushistoriaToolStripMenuItem.Name = "tilaushistoriaToolStripMenuItem";
            this.tilaushistoriaToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.tilaushistoriaToolStripMenuItem.Text = "Tilaushistoria";
            // 
            // asiakkaatToolStripMenuItem
            // 
            this.asiakkaatToolStripMenuItem.Name = "asiakkaatToolStripMenuItem";
            this.asiakkaatToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.asiakkaatToolStripMenuItem.Text = "Asetukset";
            // 
            // ohjeetToolStripMenuItem
            // 
            this.ohjeetToolStripMenuItem.Name = "ohjeetToolStripMenuItem";
            this.ohjeetToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.ohjeetToolStripMenuItem.Text = "Ohjeet";
            // 
            // Management_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 727);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Management_tab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tietojen hallinta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toimipisteetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varauksetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ohjeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakkaatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilaushistoriaToolStripMenuItem;
    }
}