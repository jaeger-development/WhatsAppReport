/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */
 
namespace WhatsAppReport
{
    partial class FormEinstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEinstellungen));
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonAbbruch = new System.Windows.Forms.Button();
            this.labelHinweis = new System.Windows.Forms.Label();
            this.tabPageAllgemein = new System.Windows.Forms.TabPage();
            this.checkBoxShowMenuDebug = new System.Windows.Forms.CheckBox();
            this.labelInfoDebug = new System.Windows.Forms.Label();
            this.tabPageBerichte = new System.Windows.Forms.TabPage();
            this.numericUpDownChatprotokollMaxBildbreite = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownReportSchriftgroesseUeberschrift = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollMaxBildbreite = new System.Windows.Forms.Label();
            this.numericUpDownChatprotokollMaxBildhoehe = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownReportSchriftgroesseText = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollSchriftgroesseText = new System.Windows.Forms.Label();
            this.labelChatprotokollMaxBildhoehe = new System.Windows.Forms.Label();
            this.labelChatprotokollSchriftgroesseUeberschrift = new System.Windows.Forms.Label();
            this.labelSchriftgroessen = new System.Windows.Forms.Label();
            this.labelBildgroessen = new System.Windows.Forms.Label();
            this.numericUpDownReportSchriftgroesseTitel = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollSchriftgroesseTitel = new System.Windows.Forms.Label();
            this.numericUpDownChatprotokollMaxEmoticonbreite = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollMaxEmoticonbreite = new System.Windows.Forms.Label();
            this.numericUpDownChatprotokollMaxEmoticonhoehe = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollMaxEmoticonhoehe = new System.Windows.Forms.Label();
            this.labelEmoticongroesse = new System.Windows.Forms.Label();
            this.tabControlEinstellungen = new System.Windows.Forms.TabControl();
            this.tabPageAllgemein.SuspendLayout();
            this.tabPageBerichte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildbreite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseUeberschrift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildhoehe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseTitel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonbreite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonhoehe)).BeginInit();
            this.tabControlEinstellungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(730, 469);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 0;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonAbbruch
            // 
            this.buttonAbbruch.Location = new System.Drawing.Point(634, 469);
            this.buttonAbbruch.Name = "buttonAbbruch";
            this.buttonAbbruch.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbruch.TabIndex = 1;
            this.buttonAbbruch.Text = "Abbruch";
            this.buttonAbbruch.UseVisualStyleBackColor = true;
            this.buttonAbbruch.Click += new System.EventHandler(this.buttonAbbruch_Click);
            // 
            // labelHinweis
            // 
            this.labelHinweis.AutoSize = true;
            this.labelHinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHinweis.Location = new System.Drawing.Point(13, 13);
            this.labelHinweis.Name = "labelHinweis";
            this.labelHinweis.Size = new System.Drawing.Size(319, 13);
            this.labelHinweis.TabIndex = 13;
            this.labelHinweis.Text = "Änderungen werden erst nach einem Neustart wirksam!";
            // 
            // tabPageAllgemein
            // 
            this.tabPageAllgemein.Controls.Add(this.labelInfoDebug);
            this.tabPageAllgemein.Controls.Add(this.checkBoxShowMenuDebug);
            this.tabPageAllgemein.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllgemein.Name = "tabPageAllgemein";
            this.tabPageAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllgemein.Size = new System.Drawing.Size(785, 388);
            this.tabPageAllgemein.TabIndex = 1;
            this.tabPageAllgemein.Text = "Allgemein";
            this.tabPageAllgemein.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowMenuDebug
            // 
            this.checkBoxShowMenuDebug.AutoSize = true;
            this.checkBoxShowMenuDebug.Location = new System.Drawing.Point(9, 36);
            this.checkBoxShowMenuDebug.Name = "checkBoxShowMenuDebug";
            this.checkBoxShowMenuDebug.Size = new System.Drawing.Size(134, 17);
            this.checkBoxShowMenuDebug.TabIndex = 0;
            this.checkBoxShowMenuDebug.Text = "Debug-Menü anzeigen";
            this.checkBoxShowMenuDebug.UseVisualStyleBackColor = true;
            // 
            // labelInfoDebug
            // 
            this.labelInfoDebug.AutoSize = true;
            this.labelInfoDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoDebug.Location = new System.Drawing.Point(6, 16);
            this.labelInfoDebug.Name = "labelInfoDebug";
            this.labelInfoDebug.Size = new System.Drawing.Size(98, 13);
            this.labelInfoDebug.TabIndex = 1;
            this.labelInfoDebug.Text = "Fehlerbehebung";
            // 
            // tabPageBerichte
            // 
            this.tabPageBerichte.Controls.Add(this.labelEmoticongroesse);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollMaxEmoticonhoehe);
            this.tabPageBerichte.Controls.Add(this.numericUpDownChatprotokollMaxEmoticonhoehe);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollMaxEmoticonbreite);
            this.tabPageBerichte.Controls.Add(this.numericUpDownChatprotokollMaxEmoticonbreite);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollSchriftgroesseTitel);
            this.tabPageBerichte.Controls.Add(this.numericUpDownReportSchriftgroesseTitel);
            this.tabPageBerichte.Controls.Add(this.labelBildgroessen);
            this.tabPageBerichte.Controls.Add(this.labelSchriftgroessen);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollSchriftgroesseUeberschrift);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollMaxBildhoehe);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollSchriftgroesseText);
            this.tabPageBerichte.Controls.Add(this.numericUpDownReportSchriftgroesseText);
            this.tabPageBerichte.Controls.Add(this.numericUpDownChatprotokollMaxBildhoehe);
            this.tabPageBerichte.Controls.Add(this.labelChatprotokollMaxBildbreite);
            this.tabPageBerichte.Controls.Add(this.numericUpDownReportSchriftgroesseUeberschrift);
            this.tabPageBerichte.Controls.Add(this.numericUpDownChatprotokollMaxBildbreite);
            this.tabPageBerichte.Location = new System.Drawing.Point(4, 22);
            this.tabPageBerichte.Name = "tabPageBerichte";
            this.tabPageBerichte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBerichte.Size = new System.Drawing.Size(785, 388);
            this.tabPageBerichte.TabIndex = 0;
            this.tabPageBerichte.Text = "Berichte";
            this.tabPageBerichte.UseVisualStyleBackColor = true;
            // 
            // numericUpDownChatprotokollMaxBildbreite
            // 
            this.numericUpDownChatprotokollMaxBildbreite.Location = new System.Drawing.Point(89, 153);
            this.numericUpDownChatprotokollMaxBildbreite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownChatprotokollMaxBildbreite.Name = "numericUpDownChatprotokollMaxBildbreite";
            this.numericUpDownChatprotokollMaxBildbreite.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownChatprotokollMaxBildbreite.TabIndex = 5;
            this.numericUpDownChatprotokollMaxBildbreite.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownReportSchriftgroesseUeberschrift
            // 
            this.numericUpDownReportSchriftgroesseUeberschrift.Location = new System.Drawing.Point(89, 65);
            this.numericUpDownReportSchriftgroesseUeberschrift.Name = "numericUpDownReportSchriftgroesseUeberschrift";
            this.numericUpDownReportSchriftgroesseUeberschrift.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownReportSchriftgroesseUeberschrift.TabIndex = 8;
            this.numericUpDownReportSchriftgroesseUeberschrift.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // labelChatprotokollMaxBildbreite
            // 
            this.labelChatprotokollMaxBildbreite.AutoSize = true;
            this.labelChatprotokollMaxBildbreite.Location = new System.Drawing.Point(6, 155);
            this.labelChatprotokollMaxBildbreite.Name = "labelChatprotokollMaxBildbreite";
            this.labelChatprotokollMaxBildbreite.Size = new System.Drawing.Size(62, 13);
            this.labelChatprotokollMaxBildbreite.TabIndex = 4;
            this.labelChatprotokollMaxBildbreite.Text = "max. Breite:";
            // 
            // numericUpDownChatprotokollMaxBildhoehe
            // 
            this.numericUpDownChatprotokollMaxBildhoehe.Location = new System.Drawing.Point(89, 179);
            this.numericUpDownChatprotokollMaxBildhoehe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownChatprotokollMaxBildhoehe.Name = "numericUpDownChatprotokollMaxBildhoehe";
            this.numericUpDownChatprotokollMaxBildhoehe.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownChatprotokollMaxBildhoehe.TabIndex = 9;
            this.numericUpDownChatprotokollMaxBildhoehe.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numericUpDownReportSchriftgroesseText
            // 
            this.numericUpDownReportSchriftgroesseText.Location = new System.Drawing.Point(89, 91);
            this.numericUpDownReportSchriftgroesseText.Name = "numericUpDownReportSchriftgroesseText";
            this.numericUpDownReportSchriftgroesseText.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownReportSchriftgroesseText.TabIndex = 3;
            this.numericUpDownReportSchriftgroesseText.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelChatprotokollSchriftgroesseText
            // 
            this.labelChatprotokollSchriftgroesseText.AutoSize = true;
            this.labelChatprotokollSchriftgroesseText.Location = new System.Drawing.Point(6, 93);
            this.labelChatprotokollSchriftgroesseText.Name = "labelChatprotokollSchriftgroesseText";
            this.labelChatprotokollSchriftgroesseText.Size = new System.Drawing.Size(31, 13);
            this.labelChatprotokollSchriftgroesseText.TabIndex = 2;
            this.labelChatprotokollSchriftgroesseText.Text = "Text:";
            // 
            // labelChatprotokollMaxBildhoehe
            // 
            this.labelChatprotokollMaxBildhoehe.AutoSize = true;
            this.labelChatprotokollMaxBildhoehe.Location = new System.Drawing.Point(6, 181);
            this.labelChatprotokollMaxBildhoehe.Name = "labelChatprotokollMaxBildhoehe";
            this.labelChatprotokollMaxBildhoehe.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollMaxBildhoehe.TabIndex = 11;
            this.labelChatprotokollMaxBildhoehe.Text = "max. Höhe:";
            // 
            // labelChatprotokollSchriftgroesseUeberschrift
            // 
            this.labelChatprotokollSchriftgroesseUeberschrift.AutoSize = true;
            this.labelChatprotokollSchriftgroesseUeberschrift.Location = new System.Drawing.Point(6, 65);
            this.labelChatprotokollSchriftgroesseUeberschrift.Name = "labelChatprotokollSchriftgroesseUeberschrift";
            this.labelChatprotokollSchriftgroesseUeberschrift.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollSchriftgroesseUeberschrift.TabIndex = 10;
            this.labelChatprotokollSchriftgroesseUeberschrift.Text = "Überschrift:";
            // 
            // labelSchriftgroessen
            // 
            this.labelSchriftgroessen.AutoSize = true;
            this.labelSchriftgroessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchriftgroessen.Location = new System.Drawing.Point(6, 16);
            this.labelSchriftgroessen.Name = "labelSchriftgroessen";
            this.labelSchriftgroessen.Size = new System.Drawing.Size(83, 13);
            this.labelSchriftgroessen.TabIndex = 12;
            this.labelSchriftgroessen.Text = "Schriftgrößen";
            // 
            // labelBildgroessen
            // 
            this.labelBildgroessen.AutoSize = true;
            this.labelBildgroessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBildgroessen.Location = new System.Drawing.Point(6, 131);
            this.labelBildgroessen.Name = "labelBildgroessen";
            this.labelBildgroessen.Size = new System.Drawing.Size(67, 13);
            this.labelBildgroessen.TabIndex = 13;
            this.labelBildgroessen.Text = "Bildgrößen";
            // 
            // numericUpDownReportSchriftgroesseTitel
            // 
            this.numericUpDownReportSchriftgroesseTitel.Location = new System.Drawing.Point(89, 39);
            this.numericUpDownReportSchriftgroesseTitel.Name = "numericUpDownReportSchriftgroesseTitel";
            this.numericUpDownReportSchriftgroesseTitel.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownReportSchriftgroesseTitel.TabIndex = 14;
            this.numericUpDownReportSchriftgroesseTitel.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // labelChatprotokollSchriftgroesseTitel
            // 
            this.labelChatprotokollSchriftgroesseTitel.AutoSize = true;
            this.labelChatprotokollSchriftgroesseTitel.Location = new System.Drawing.Point(6, 39);
            this.labelChatprotokollSchriftgroesseTitel.Name = "labelChatprotokollSchriftgroesseTitel";
            this.labelChatprotokollSchriftgroesseTitel.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollSchriftgroesseTitel.TabIndex = 15;
            this.labelChatprotokollSchriftgroesseTitel.Text = "Überschrift:";
            // 
            // numericUpDownChatprotokollMaxEmoticonbreite
            // 
            this.numericUpDownChatprotokollMaxEmoticonbreite.Location = new System.Drawing.Point(89, 244);
            this.numericUpDownChatprotokollMaxEmoticonbreite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownChatprotokollMaxEmoticonbreite.Name = "numericUpDownChatprotokollMaxEmoticonbreite";
            this.numericUpDownChatprotokollMaxEmoticonbreite.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownChatprotokollMaxEmoticonbreite.TabIndex = 17;
            this.numericUpDownChatprotokollMaxEmoticonbreite.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // labelChatprotokollMaxEmoticonbreite
            // 
            this.labelChatprotokollMaxEmoticonbreite.AutoSize = true;
            this.labelChatprotokollMaxEmoticonbreite.Location = new System.Drawing.Point(6, 246);
            this.labelChatprotokollMaxEmoticonbreite.Name = "labelChatprotokollMaxEmoticonbreite";
            this.labelChatprotokollMaxEmoticonbreite.Size = new System.Drawing.Size(62, 13);
            this.labelChatprotokollMaxEmoticonbreite.TabIndex = 16;
            this.labelChatprotokollMaxEmoticonbreite.Text = "max. Breite:";
            // 
            // numericUpDownChatprotokollMaxEmoticonhoehe
            // 
            this.numericUpDownChatprotokollMaxEmoticonhoehe.Location = new System.Drawing.Point(89, 270);
            this.numericUpDownChatprotokollMaxEmoticonhoehe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownChatprotokollMaxEmoticonhoehe.Name = "numericUpDownChatprotokollMaxEmoticonhoehe";
            this.numericUpDownChatprotokollMaxEmoticonhoehe.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownChatprotokollMaxEmoticonhoehe.TabIndex = 18;
            this.numericUpDownChatprotokollMaxEmoticonhoehe.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // labelChatprotokollMaxEmoticonhoehe
            // 
            this.labelChatprotokollMaxEmoticonhoehe.AutoSize = true;
            this.labelChatprotokollMaxEmoticonhoehe.Location = new System.Drawing.Point(6, 272);
            this.labelChatprotokollMaxEmoticonhoehe.Name = "labelChatprotokollMaxEmoticonhoehe";
            this.labelChatprotokollMaxEmoticonhoehe.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollMaxEmoticonhoehe.TabIndex = 19;
            this.labelChatprotokollMaxEmoticonhoehe.Text = "max. Höhe:";
            // 
            // labelEmoticongroesse
            // 
            this.labelEmoticongroesse.AutoSize = true;
            this.labelEmoticongroesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmoticongroesse.Location = new System.Drawing.Point(6, 222);
            this.labelEmoticongroesse.Name = "labelEmoticongroesse";
            this.labelEmoticongroesse.Size = new System.Drawing.Size(98, 13);
            this.labelEmoticongroesse.TabIndex = 20;
            this.labelEmoticongroesse.Text = "Emoticongrößen";
            // 
            // tabControlEinstellungen
            // 
            this.tabControlEinstellungen.Controls.Add(this.tabPageBerichte);
            this.tabControlEinstellungen.Controls.Add(this.tabPageAllgemein);
            this.tabControlEinstellungen.Location = new System.Drawing.Point(12, 40);
            this.tabControlEinstellungen.Name = "tabControlEinstellungen";
            this.tabControlEinstellungen.SelectedIndex = 0;
            this.tabControlEinstellungen.Size = new System.Drawing.Size(793, 414);
            this.tabControlEinstellungen.TabIndex = 12;
            // 
            // FormEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 504);
            this.Controls.Add(this.labelHinweis);
            this.Controls.Add(this.tabControlEinstellungen);
            this.Controls.Add(this.buttonAbbruch);
            this.Controls.Add(this.buttonSpeichern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEinstellungen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.FormEinstellungen_Load);
            this.tabPageAllgemein.ResumeLayout(false);
            this.tabPageAllgemein.PerformLayout();
            this.tabPageBerichte.ResumeLayout(false);
            this.tabPageBerichte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildbreite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseUeberschrift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildhoehe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseTitel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonbreite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonhoehe)).EndInit();
            this.tabControlEinstellungen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAbbruch;
        private System.Windows.Forms.Label labelHinweis;
        private System.Windows.Forms.TabPage tabPageAllgemein;
        private System.Windows.Forms.Label labelInfoDebug;
        private System.Windows.Forms.CheckBox checkBoxShowMenuDebug;
        private System.Windows.Forms.TabPage tabPageBerichte;
        private System.Windows.Forms.Label labelEmoticongroesse;
        private System.Windows.Forms.Label labelChatprotokollMaxEmoticonhoehe;
        private System.Windows.Forms.NumericUpDown numericUpDownChatprotokollMaxEmoticonhoehe;
        private System.Windows.Forms.Label labelChatprotokollMaxEmoticonbreite;
        private System.Windows.Forms.NumericUpDown numericUpDownChatprotokollMaxEmoticonbreite;
        private System.Windows.Forms.Label labelChatprotokollSchriftgroesseTitel;
        private System.Windows.Forms.NumericUpDown numericUpDownReportSchriftgroesseTitel;
        private System.Windows.Forms.Label labelBildgroessen;
        private System.Windows.Forms.Label labelSchriftgroessen;
        private System.Windows.Forms.Label labelChatprotokollSchriftgroesseUeberschrift;
        private System.Windows.Forms.Label labelChatprotokollMaxBildhoehe;
        private System.Windows.Forms.Label labelChatprotokollSchriftgroesseText;
        private System.Windows.Forms.NumericUpDown numericUpDownReportSchriftgroesseText;
        private System.Windows.Forms.NumericUpDown numericUpDownChatprotokollMaxBildhoehe;
        private System.Windows.Forms.Label labelChatprotokollMaxBildbreite;
        private System.Windows.Forms.NumericUpDown numericUpDownReportSchriftgroesseUeberschrift;
        private System.Windows.Forms.NumericUpDown numericUpDownChatprotokollMaxBildbreite;
        private System.Windows.Forms.TabControl tabControlEinstellungen;
    }
}