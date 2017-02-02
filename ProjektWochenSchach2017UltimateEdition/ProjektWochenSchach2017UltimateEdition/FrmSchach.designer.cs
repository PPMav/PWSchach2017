namespace SchachTest
{
    partial class FrmSchach
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenue = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNeuesSpiel = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpieler = new System.Windows.Forms.Label();
            this.msMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenue
            // 
            this.msMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.msMenue.Location = new System.Drawing.Point(0, 0);
            this.msMenue.Name = "msMenue";
            this.msMenue.Size = new System.Drawing.Size(505, 24);
            this.msMenue.TabIndex = 83;
            this.msMenue.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNeuesSpiel});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // msiNeuesSpiel
            // 
            this.msiNeuesSpiel.Name = "msiNeuesSpiel";
            this.msiNeuesSpiel.Size = new System.Drawing.Size(135, 22);
            this.msiNeuesSpiel.Text = "Neues Spiel";
            this.msiNeuesSpiel.Click += new System.EventHandler(this.msiNeuesSpiel_Click);
            // 
            // lblSpieler
            // 
            this.lblSpieler.AutoSize = true;
            this.lblSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpieler.Location = new System.Drawing.Point(12, 484);
            this.lblSpieler.Name = "lblSpieler";
            this.lblSpieler.Size = new System.Drawing.Size(334, 39);
            this.lblSpieler.TabIndex = 84;
            this.lblSpieler.Text = "Aktiver Spieler: weiß";
            // 
            // FrmSchach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 532);
            this.Controls.Add(this.lblSpieler);
            this.Controls.Add(this.msMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msMenue;
            this.MaximizeBox = false;
            this.Name = "FrmSchach";
            this.Text = "xXUltimateSchachXx";
            this.Load += new System.EventHandler(this.FrmSchach_Load);
            this.msMenue.ResumeLayout(false);
            this.msMenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenue;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiNeuesSpiel;
        private System.Windows.Forms.Label lblSpieler;
    }
}

