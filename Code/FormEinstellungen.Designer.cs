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
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.labelInfoDebug = new System.Windows.Forms.Label();
            this.checkBoxShowMenuDebug = new System.Windows.Forms.CheckBox();
            this.tabPageLayout = new System.Windows.Forms.TabPage();
            this.labelEmoticongroesse = new System.Windows.Forms.Label();
            this.labelChatprotokollMaxEmoticonhoehe = new System.Windows.Forms.Label();
            this.numericUpDownChatprotokollMaxEmoticonhoehe = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollMaxEmoticonbreite = new System.Windows.Forms.Label();
            this.numericUpDownChatprotokollMaxEmoticonbreite = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollSchriftgroesseTitel = new System.Windows.Forms.Label();
            this.numericUpDownReportSchriftgroesseTitel = new System.Windows.Forms.NumericUpDown();
            this.labelBildgroessen = new System.Windows.Forms.Label();
            this.labelSchriftgroessen = new System.Windows.Forms.Label();
            this.labelChatprotokollSchriftgroesseUeberschrift = new System.Windows.Forms.Label();
            this.labelChatprotokollMaxBildhoehe = new System.Windows.Forms.Label();
            this.labelChatprotokollSchriftgroesseText = new System.Windows.Forms.Label();
            this.numericUpDownReportSchriftgroesseText = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChatprotokollMaxBildhoehe = new System.Windows.Forms.NumericUpDown();
            this.labelChatprotokollMaxBildbreite = new System.Windows.Forms.Label();
            this.numericUpDownReportSchriftgroesseUeberschrift = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChatprotokollMaxBildbreite = new System.Windows.Forms.NumericUpDown();
            this.tabControlEinstellungen = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.labelBehoerde = new System.Windows.Forms.Label();
            this.labelDienststelle = new System.Windows.Forms.Label();
            this.textBoxBehoerde = new System.Windows.Forms.TextBox();
            this.textBoxDienststelle = new System.Windows.Forms.TextBox();
            this.textBoxSachbearbeiter = new System.Windows.Forms.TextBox();
            this.labelSachbearbeiter = new System.Windows.Forms.Label();
            this.tabPageDebug.SuspendLayout();
            this.tabPageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonhoehe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonbreite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseTitel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildhoehe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseUeberschrift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildbreite)).BeginInit();
            this.tabControlEinstellungen.SuspendLayout();
            this.tabPageUser.SuspendLayout();
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
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.labelInfoDebug);
            this.tabPageDebug.Controls.Add(this.checkBoxShowMenuDebug);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(785, 388);
            this.tabPageDebug.TabIndex = 1;
            this.tabPageDebug.Text = "Debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
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
            // tabPageLayout
            // 
            this.tabPageLayout.Controls.Add(this.labelEmoticongroesse);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollMaxEmoticonhoehe);
            this.tabPageLayout.Controls.Add(this.numericUpDownChatprotokollMaxEmoticonhoehe);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollMaxEmoticonbreite);
            this.tabPageLayout.Controls.Add(this.numericUpDownChatprotokollMaxEmoticonbreite);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollSchriftgroesseTitel);
            this.tabPageLayout.Controls.Add(this.numericUpDownReportSchriftgroesseTitel);
            this.tabPageLayout.Controls.Add(this.labelBildgroessen);
            this.tabPageLayout.Controls.Add(this.labelSchriftgroessen);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollSchriftgroesseUeberschrift);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollMaxBildhoehe);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollSchriftgroesseText);
            this.tabPageLayout.Controls.Add(this.numericUpDownReportSchriftgroesseText);
            this.tabPageLayout.Controls.Add(this.numericUpDownChatprotokollMaxBildhoehe);
            this.tabPageLayout.Controls.Add(this.labelChatprotokollMaxBildbreite);
            this.tabPageLayout.Controls.Add(this.numericUpDownReportSchriftgroesseUeberschrift);
            this.tabPageLayout.Controls.Add(this.numericUpDownChatprotokollMaxBildbreite);
            this.tabPageLayout.Location = new System.Drawing.Point(4, 22);
            this.tabPageLayout.Name = "tabPageLayout";
            this.tabPageLayout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLayout.Size = new System.Drawing.Size(785, 388);
            this.tabPageLayout.TabIndex = 0;
            this.tabPageLayout.Text = "Layout";
            this.tabPageLayout.UseVisualStyleBackColor = true;
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
            // labelChatprotokollMaxEmoticonhoehe
            // 
            this.labelChatprotokollMaxEmoticonhoehe.AutoSize = true;
            this.labelChatprotokollMaxEmoticonhoehe.Location = new System.Drawing.Point(6, 272);
            this.labelChatprotokollMaxEmoticonhoehe.Name = "labelChatprotokollMaxEmoticonhoehe";
            this.labelChatprotokollMaxEmoticonhoehe.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollMaxEmoticonhoehe.TabIndex = 19;
            this.labelChatprotokollMaxEmoticonhoehe.Text = "max. Höhe:";
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
            // labelChatprotokollMaxEmoticonbreite
            // 
            this.labelChatprotokollMaxEmoticonbreite.AutoSize = true;
            this.labelChatprotokollMaxEmoticonbreite.Location = new System.Drawing.Point(6, 246);
            this.labelChatprotokollMaxEmoticonbreite.Name = "labelChatprotokollMaxEmoticonbreite";
            this.labelChatprotokollMaxEmoticonbreite.Size = new System.Drawing.Size(62, 13);
            this.labelChatprotokollMaxEmoticonbreite.TabIndex = 16;
            this.labelChatprotokollMaxEmoticonbreite.Text = "max. Breite:";
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
            // labelChatprotokollSchriftgroesseTitel
            // 
            this.labelChatprotokollSchriftgroesseTitel.AutoSize = true;
            this.labelChatprotokollSchriftgroesseTitel.Location = new System.Drawing.Point(6, 39);
            this.labelChatprotokollSchriftgroesseTitel.Name = "labelChatprotokollSchriftgroesseTitel";
            this.labelChatprotokollSchriftgroesseTitel.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollSchriftgroesseTitel.TabIndex = 15;
            this.labelChatprotokollSchriftgroesseTitel.Text = "Überschrift:";
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
            // labelChatprotokollSchriftgroesseUeberschrift
            // 
            this.labelChatprotokollSchriftgroesseUeberschrift.AutoSize = true;
            this.labelChatprotokollSchriftgroesseUeberschrift.Location = new System.Drawing.Point(6, 65);
            this.labelChatprotokollSchriftgroesseUeberschrift.Name = "labelChatprotokollSchriftgroesseUeberschrift";
            this.labelChatprotokollSchriftgroesseUeberschrift.Size = new System.Drawing.Size(61, 13);
            this.labelChatprotokollSchriftgroesseUeberschrift.TabIndex = 10;
            this.labelChatprotokollSchriftgroesseUeberschrift.Text = "Überschrift:";
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
            // labelChatprotokollSchriftgroesseText
            // 
            this.labelChatprotokollSchriftgroesseText.AutoSize = true;
            this.labelChatprotokollSchriftgroesseText.Location = new System.Drawing.Point(6, 93);
            this.labelChatprotokollSchriftgroesseText.Name = "labelChatprotokollSchriftgroesseText";
            this.labelChatprotokollSchriftgroesseText.Size = new System.Drawing.Size(31, 13);
            this.labelChatprotokollSchriftgroesseText.TabIndex = 2;
            this.labelChatprotokollSchriftgroesseText.Text = "Text:";
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
            // labelChatprotokollMaxBildbreite
            // 
            this.labelChatprotokollMaxBildbreite.AutoSize = true;
            this.labelChatprotokollMaxBildbreite.Location = new System.Drawing.Point(6, 155);
            this.labelChatprotokollMaxBildbreite.Name = "labelChatprotokollMaxBildbreite";
            this.labelChatprotokollMaxBildbreite.Size = new System.Drawing.Size(62, 13);
            this.labelChatprotokollMaxBildbreite.TabIndex = 4;
            this.labelChatprotokollMaxBildbreite.Text = "max. Breite:";
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
            // tabControlEinstellungen
            // 
            this.tabControlEinstellungen.Controls.Add(this.tabPageUser);
            this.tabControlEinstellungen.Controls.Add(this.tabPageLayout);
            this.tabControlEinstellungen.Controls.Add(this.tabPageDebug);
            this.tabControlEinstellungen.Location = new System.Drawing.Point(12, 40);
            this.tabControlEinstellungen.Name = "tabControlEinstellungen";
            this.tabControlEinstellungen.SelectedIndex = 0;
            this.tabControlEinstellungen.Size = new System.Drawing.Size(793, 414);
            this.tabControlEinstellungen.TabIndex = 12;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.labelSachbearbeiter);
            this.tabPageUser.Controls.Add(this.textBoxSachbearbeiter);
            this.tabPageUser.Controls.Add(this.textBoxDienststelle);
            this.tabPageUser.Controls.Add(this.textBoxBehoerde);
            this.tabPageUser.Controls.Add(this.labelDienststelle);
            this.tabPageUser.Controls.Add(this.labelBehoerde);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(785, 388);
            this.tabPageUser.TabIndex = 2;
            this.tabPageUser.Text = "Nutzerdaten";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // labelBehoerde
            // 
            this.labelBehoerde.AutoSize = true;
            this.labelBehoerde.Location = new System.Drawing.Point(17, 18);
            this.labelBehoerde.Name = "labelBehoerde";
            this.labelBehoerde.Size = new System.Drawing.Size(47, 13);
            this.labelBehoerde.TabIndex = 0;
            this.labelBehoerde.Text = "Behörde";
            // 
            // labelDienststelle
            // 
            this.labelDienststelle.AutoSize = true;
            this.labelDienststelle.Location = new System.Drawing.Point(17, 45);
            this.labelDienststelle.Name = "labelDienststelle";
            this.labelDienststelle.Size = new System.Drawing.Size(61, 13);
            this.labelDienststelle.TabIndex = 1;
            this.labelDienststelle.Text = "Dienststelle";
            // 
            // textBoxBehoerde
            // 
            this.textBoxBehoerde.Location = new System.Drawing.Point(114, 15);
            this.textBoxBehoerde.Name = "textBoxBehoerde";
            this.textBoxBehoerde.Size = new System.Drawing.Size(217, 20);
            this.textBoxBehoerde.TabIndex = 2;
            // 
            // textBoxDienststelle
            // 
            this.textBoxDienststelle.Location = new System.Drawing.Point(114, 42);
            this.textBoxDienststelle.Name = "textBoxDienststelle";
            this.textBoxDienststelle.Size = new System.Drawing.Size(217, 20);
            this.textBoxDienststelle.TabIndex = 3;
            // 
            // textBoxSachbearbeiter
            // 
            this.textBoxSachbearbeiter.Location = new System.Drawing.Point(114, 69);
            this.textBoxSachbearbeiter.Name = "textBoxSachbearbeiter";
            this.textBoxSachbearbeiter.Size = new System.Drawing.Size(217, 20);
            this.textBoxSachbearbeiter.TabIndex = 4;
            // 
            // labelSachbearbeiter
            // 
            this.labelSachbearbeiter.AutoSize = true;
            this.labelSachbearbeiter.Location = new System.Drawing.Point(17, 72);
            this.labelSachbearbeiter.Name = "labelSachbearbeiter";
            this.labelSachbearbeiter.Size = new System.Drawing.Size(79, 13);
            this.labelSachbearbeiter.TabIndex = 5;
            this.labelSachbearbeiter.Text = "Sachbearbeiter";
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
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            this.tabPageLayout.ResumeLayout(false);
            this.tabPageLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonhoehe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxEmoticonbreite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseTitel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildhoehe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReportSchriftgroesseUeberschrift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChatprotokollMaxBildbreite)).EndInit();
            this.tabControlEinstellungen.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAbbruch;
        private System.Windows.Forms.Label labelHinweis;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.Label labelInfoDebug;
        private System.Windows.Forms.CheckBox checkBoxShowMenuDebug;
        private System.Windows.Forms.TabPage tabPageLayout;
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
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.Label labelSachbearbeiter;
        private System.Windows.Forms.TextBox textBoxSachbearbeiter;
        private System.Windows.Forms.TextBox textBoxDienststelle;
        private System.Windows.Forms.TextBox textBoxBehoerde;
        private System.Windows.Forms.Label labelDienststelle;
        private System.Windows.Forms.Label labelBehoerde;
    }
}