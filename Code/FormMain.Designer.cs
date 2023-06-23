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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgrammLadeMail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgrammLadeDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEinstellungen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebugOpenWorkDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebugOpenLogDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInfoNutzungsbedingungen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInfoLizenzbedingungen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgramminfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.richTextBoxKurzinfo = new System.Windows.Forms.RichTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProgramm,
            this.MenuItemEinstellungen,
            this.MenuItemDebug,
            this.MenuItemInfo,
            this.MenuItemHilfe});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(806, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStripMainForm";
            // 
            // MenuItemProgramm
            // 
            this.MenuItemProgramm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProgrammLadeMail,
            this.MenuItemProgrammLadeDatei,
            this.MenuItemBeenden});
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
            // MenuItemBeenden
            // 
            this.MenuItemBeenden.Name = "MenuItemBeenden";
            this.MenuItemBeenden.Size = new System.Drawing.Size(291, 22);
            this.MenuItemBeenden.Text = "Beenden";
            this.MenuItemBeenden.Click += new System.EventHandler(this.MenuItemBeenden_Click);
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
            this.MenuItemInfoNutzungsbedingungen,
            this.MenuItemInfoLizenzbedingungen,
            this.MenuItemProgramminfo});
            this.MenuItemInfo.Name = "MenuItemInfo";
            this.MenuItemInfo.Size = new System.Drawing.Size(40, 20);
            this.MenuItemInfo.Text = "Info";
            // 
            // MenuItemInfoNutzungsbedingungen
            // 
            this.MenuItemInfoNutzungsbedingungen.Name = "MenuItemInfoNutzungsbedingungen";
            this.MenuItemInfoNutzungsbedingungen.Size = new System.Drawing.Size(196, 22);
            this.MenuItemInfoNutzungsbedingungen.Text = "Nutzungsbedingungen";
            this.MenuItemInfoNutzungsbedingungen.Click += new System.EventHandler(this.MenuItemNutzungsbedingungen);
            // 
            // MenuItemInfoLizenzbedingungen
            // 
            this.MenuItemInfoLizenzbedingungen.Name = "MenuItemInfoLizenzbedingungen";
            this.MenuItemInfoLizenzbedingungen.Size = new System.Drawing.Size(196, 22);
            this.MenuItemInfoLizenzbedingungen.Text = "Lizenzbedingungen";
            this.MenuItemInfoLizenzbedingungen.Click += new System.EventHandler(this.MenuItemLizenzinfo);
            // 
            // MenuItemProgramminfo
            // 
            this.MenuItemProgramminfo.Name = "MenuItemProgramminfo";
            this.MenuItemProgramminfo.Size = new System.Drawing.Size(196, 22);
            this.MenuItemProgramminfo.Text = "Programminfo";
            this.MenuItemProgramminfo.Click += new System.EventHandler(this.MenuItemProgramminfo_Click);
            // 
            // MenuItemHilfe
            // 
            this.MenuItemHilfe.Name = "MenuItemHilfe";
            this.MenuItemHilfe.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHilfe.Text = "Hilfe";
            this.MenuItemHilfe.Click += new System.EventHandler(this.MenuItemHilfe_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 415);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(806, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // richTextBoxKurzinfo
            // 
            this.richTextBoxKurzinfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBoxKurzinfo.Location = new System.Drawing.Point(277, 27);
            this.richTextBoxKurzinfo.Name = "richTextBoxKurzinfo";
            this.richTextBoxKurzinfo.ReadOnly = true;
            this.richTextBoxKurzinfo.Size = new System.Drawing.Size(517, 385);
            this.richTextBoxKurzinfo.TabIndex = 7;
            this.richTextBoxKurzinfo.Text = "";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Image = global::WhatsAppReport.Properties.Resources.startbutton;
            this.buttonStart.Location = new System.Drawing.Point(12, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(259, 385);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonLoadEMail_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 437);
            this.Controls.Add(this.richTextBoxKurzinfo);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsAppReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgramm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgrammLadeMail;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgrammLadeDatei;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebug;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebugOpenWorkDirectory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebugOpenLogDirectory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEinstellungen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInfoLizenzbedingungen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInfoNutzungsbedingungen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHilfe;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgramminfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBeenden;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxKurzinfo;
    }
}

