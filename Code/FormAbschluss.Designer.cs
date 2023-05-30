/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */
 
namespace WhatsAppReport
{
    partial class FormAbschluss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbschluss));
            this.checkBoxNutzungsbedingungen = new System.Windows.Forms.CheckBox();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.buttonAbbruch = new System.Windows.Forms.Button();
            this.labelInfoHeader = new System.Windows.Forms.Label();
            this.linkLabelNutzungsbedingungen = new System.Windows.Forms.LinkLabel();
            this.labelNutzungsbedingungenRest = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxNutzungsbedingungen
            // 
            this.checkBoxNutzungsbedingungen.AutoSize = true;
            this.checkBoxNutzungsbedingungen.Location = new System.Drawing.Point(12, 111);
            this.checkBoxNutzungsbedingungen.Name = "checkBoxNutzungsbedingungen";
            this.checkBoxNutzungsbedingungen.Size = new System.Drawing.Size(85, 17);
            this.checkBoxNutzungsbedingungen.TabIndex = 0;
            this.checkBoxNutzungsbedingungen.Text = "Ich habe die";
            this.checkBoxNutzungsbedingungen.UseVisualStyleBackColor = true;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.Location = new System.Drawing.Point(554, 157);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(75, 23);
            this.buttonWeiter.TabIndex = 1;
            this.buttonWeiter.Text = "Weiter";
            this.buttonWeiter.UseVisualStyleBackColor = true;
            this.buttonWeiter.Click += new System.EventHandler(this.buttonWeiter_Click);
            // 
            // buttonAbbruch
            // 
            this.buttonAbbruch.Location = new System.Drawing.Point(12, 157);
            this.buttonAbbruch.Name = "buttonAbbruch";
            this.buttonAbbruch.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbruch.TabIndex = 2;
            this.buttonAbbruch.Text = "Abbruch";
            this.buttonAbbruch.UseVisualStyleBackColor = true;
            this.buttonAbbruch.Click += new System.EventHandler(this.buttonAbbruch_Click);
            // 
            // labelInfoHeader
            // 
            this.labelInfoHeader.AutoSize = true;
            this.labelInfoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoHeader.Location = new System.Drawing.Point(12, 9);
            this.labelInfoHeader.Name = "labelInfoHeader";
            this.labelInfoHeader.Size = new System.Drawing.Size(229, 20);
            this.labelInfoHeader.TabIndex = 3;
            this.labelInfoHeader.Text = "Auswertung abgeschlossen";
            // 
            // linkLabelNutzungsbedingungen
            // 
            this.linkLabelNutzungsbedingungen.AutoSize = true;
            this.linkLabelNutzungsbedingungen.Location = new System.Drawing.Point(91, 112);
            this.linkLabelNutzungsbedingungen.Name = "linkLabelNutzungsbedingungen";
            this.linkLabelNutzungsbedingungen.Size = new System.Drawing.Size(114, 13);
            this.linkLabelNutzungsbedingungen.TabIndex = 5;
            this.linkLabelNutzungsbedingungen.TabStop = true;
            this.linkLabelNutzungsbedingungen.Text = "Nutzungsbedingungen";
            this.linkLabelNutzungsbedingungen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNutzungsbedingungen_LinkClicked);
            // 
            // labelNutzungsbedingungenRest
            // 
            this.labelNutzungsbedingungenRest.AutoSize = true;
            this.labelNutzungsbedingungenRest.Location = new System.Drawing.Point(202, 112);
            this.labelNutzungsbedingungenRest.Name = "labelNutzungsbedingungenRest";
            this.labelNutzungsbedingungenRest.Size = new System.Drawing.Size(117, 13);
            this.labelNutzungsbedingungenRest.TabIndex = 6;
            this.labelNutzungsbedingungenRest.Text = "gelesen und akzeptiert.";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 39);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(573, 39);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // FormAbschluss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 192);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelNutzungsbedingungenRest);
            this.Controls.Add(this.linkLabelNutzungsbedingungen);
            this.Controls.Add(this.labelInfoHeader);
            this.Controls.Add(this.buttonAbbruch);
            this.Controls.Add(this.buttonWeiter);
            this.Controls.Add(this.checkBoxNutzungsbedingungen);
            this.Name = "FormAbschluss";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abschluss";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNutzungsbedingungen;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.Button buttonAbbruch;
        private System.Windows.Forms.Label labelInfoHeader;
        private System.Windows.Forms.LinkLabel linkLabelNutzungsbedingungen;
        private System.Windows.Forms.Label labelNutzungsbedingungenRest;
        private System.Windows.Forms.Label labelInfo;
    }
}