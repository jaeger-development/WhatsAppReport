﻿namespace WhatsAppReport
{
    partial class FormLizenz
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
            this.richTextBoxLizenz = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxLizenz
            // 
            this.richTextBoxLizenz.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxLizenz.Name = "richTextBoxLizenz";
            this.richTextBoxLizenz.Size = new System.Drawing.Size(765, 598);
            this.richTextBoxLizenz.TabIndex = 0;
            this.richTextBoxLizenz.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(702, 616);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Schließen";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormLizenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 651);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxLizenz);
            this.Name = "FormLizenz";
            this.Text = "Lizenzinformationen";
            this.Load += new System.EventHandler(this.FormLizenz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLizenz;
        private System.Windows.Forms.Button buttonClose;
    }
}