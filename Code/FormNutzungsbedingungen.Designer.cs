namespace WhatsAppReport
{
    partial class FormNutzungsbedingungen
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
            this.richTextBoxNutzungsbedingungen = new System.Windows.Forms.RichTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxNutzungsbedingungen
            // 
            this.richTextBoxNutzungsbedingungen.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxNutzungsbedingungen.Name = "richTextBoxNutzungsbedingungen";
            this.richTextBoxNutzungsbedingungen.Size = new System.Drawing.Size(941, 503);
            this.richTextBoxNutzungsbedingungen.TabIndex = 0;
            this.richTextBoxNutzungsbedingungen.Text = "";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(879, 522);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormNutzungsbedingungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 557);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.richTextBoxNutzungsbedingungen);
            this.Name = "FormNutzungsbedingungen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nutzungsbedingungen";
            this.Load += new System.EventHandler(this.FormNutzungsbedingungen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNutzungsbedingungen;
        private System.Windows.Forms.Button buttonOK;
    }
}