namespace WhatsAppReport
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.MenuItemProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgrammLadeMail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgrammLadeDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgrammBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEinstellungen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebugOpenWorkDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebugOpenLogDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInfoNutzungsbedingungen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInfoLizenzbedingungen = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMainForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainForm.SuspendLayout();
            this.statusStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProgramm,
            this.MenuItemEinstellungen,
            this.MenuItemDebug,
            this.MenuItemHilfe,
            this.MenuItemInfo});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(950, 24);
            this.menuStripMainForm.TabIndex = 5;
            this.menuStripMainForm.Text = "menuStripMainForm";
            // 
            // MenuItemProgramm
            // 
            this.MenuItemProgramm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProgrammLadeMail,
            this.MenuItemProgrammLadeDatei,
            this.MenuItemProgrammBeenden});
            this.MenuItemProgramm.Name = "MenuItemProgramm";
            this.MenuItemProgramm.Size = new System.Drawing.Size(76, 20);
            this.MenuItemProgramm.Text = "Programm";
            // 
            // MenuItemProgrammLadeMail
            // 
            this.MenuItemProgrammLadeMail.Name = "MenuItemProgrammLadeMail";
            this.MenuItemProgrammLadeMail.Size = new System.Drawing.Size(291, 22);
            this.MenuItemProgrammLadeMail.Text = "Lade Chat aus Outlook-Mail (empfohlen)";
            this.MenuItemProgrammLadeMail.Click += new System.EventHandler(this.MenuItemLadeEMail_Click);
            // 
            // MenuItemProgrammLadeDatei
            // 
            this.MenuItemProgrammLadeDatei.Name = "MenuItemProgrammLadeDatei";
            this.MenuItemProgrammLadeDatei.Size = new System.Drawing.Size(291, 22);
            this.MenuItemProgrammLadeDatei.Text = "Lade Chat aus Verzeichnis";
            this.MenuItemProgrammLadeDatei.Click += new System.EventHandler(this.MenuItemLadeDatei_Click);
            // 
            // MenuItemProgrammBeenden
            // 
            this.MenuItemProgrammBeenden.Name = "MenuItemProgrammBeenden";
            this.MenuItemProgrammBeenden.Size = new System.Drawing.Size(291, 22);
            this.MenuItemProgrammBeenden.Text = "Beenden";
            this.MenuItemProgrammBeenden.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // MenuItemEinstellungen
            // 
            this.MenuItemEinstellungen.Name = "MenuItemEinstellungen";
            this.MenuItemEinstellungen.Size = new System.Drawing.Size(90, 20);
            this.MenuItemEinstellungen.Text = "Einstellungen";
            this.MenuItemEinstellungen.Click += new System.EventHandler(this.MenuItemEinstellungen_Click);
            // 
            // MenuItemDebug
            // 
            this.MenuItemDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDebugOpenWorkDirectory,
            this.MenuItemDebugOpenLogDirectory});
            this.MenuItemDebug.Name = "MenuItemDebug";
            this.MenuItemDebug.Size = new System.Drawing.Size(54, 20);
            this.MenuItemDebug.Text = "Debug";
            // 
            // MenuItemDebugOpenWorkDirectory
            // 
            this.MenuItemDebugOpenWorkDirectory.Name = "MenuItemDebugOpenWorkDirectory";
            this.MenuItemDebugOpenWorkDirectory.Size = new System.Drawing.Size(202, 22);
            this.MenuItemDebugOpenWorkDirectory.Text = "Öffne Arbeitsverzeichnis";
            this.MenuItemDebugOpenWorkDirectory.Click += new System.EventHandler(this.MenuItemOpenWorkFolder_Click);
            // 
            // MenuItemDebugOpenLogDirectory
            // 
            this.MenuItemDebugOpenLogDirectory.Name = "MenuItemDebugOpenLogDirectory";
            this.MenuItemDebugOpenLogDirectory.Size = new System.Drawing.Size(202, 22);
            this.MenuItemDebugOpenLogDirectory.Text = "Öffne Logverzeichnis";
            this.MenuItemDebugOpenLogDirectory.Click += new System.EventHandler(this.MenuItemOpenLogFolder_Click);
            // 
            // MenuItemInfo
            // 
            this.MenuItemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1,
            this.MenuItemInfoNutzungsbedingungen,
            this.MenuItemInfoLizenzbedingungen});
            this.MenuItemInfo.Name = "MenuItemInfo";
            this.MenuItemInfo.Size = new System.Drawing.Size(40, 20);
            this.MenuItemInfo.Text = "Info";
            // 
            // MenuItemInfoNutzungsbedingungen
            // 
            this.MenuItemInfoNutzungsbedingungen.Name = "MenuItemInfoNutzungsbedingungen";
            this.MenuItemInfoNutzungsbedingungen.Size = new System.Drawing.Size(196, 22);
            this.MenuItemInfoNutzungsbedingungen.Text = "Nutzungsbedingungen";
            this.MenuItemInfoNutzungsbedingungen.Click += new System.EventHandler(this.nutzungsbedingungenToolStripMenuItem1_Click);
            // 
            // MenuItemInfoLizenzbedingungen
            // 
            this.MenuItemInfoLizenzbedingungen.Name = "MenuItemInfoLizenzbedingungen";
            this.MenuItemInfoLizenzbedingungen.Size = new System.Drawing.Size(196, 22);
            this.MenuItemInfoLizenzbedingungen.Text = "Lizenzbedingungen";
            this.MenuItemInfoLizenzbedingungen.Click += new System.EventHandler(this.lizenzToolStripMenuItem_Click);
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMainForm});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 476);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(950, 22);
            this.statusStripMainForm.TabIndex = 7;
            // 
            // toolStripStatusLabelMainForm
            // 
            this.toolStripStatusLabelMainForm.Name = "toolStripStatusLabelMainForm";
            this.toolStripStatusLabelMainForm.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelMainForm.Text = "Bereit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 498);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainForm;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WhatsAppReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgramm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgrammLadeMail;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMainForm;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgrammLadeDatei;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebug;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebugOpenWorkDirectory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebugOpenLogDirectory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEinstellungen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInfoLizenzbedingungen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInfoNutzungsbedingungen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgrammBeenden;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHilfe;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
    }
}

