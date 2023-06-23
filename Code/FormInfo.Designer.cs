namespace WhatsAppReport
{
    partial class FormInfo
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.labelStaticProgrammversion = new System.Windows.Forms.Label();
            this.labelDynamicProgrammversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Schließen";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(776, 395);
            this.richTextBoxInfo.TabIndex = 1;
            this.richTextBoxInfo.Text = "";
            // 
            // labelStaticProgrammversion
            // 
            this.labelStaticProgrammversion.AutoSize = true;
            this.labelStaticProgrammversion.Location = new System.Drawing.Point(12, 415);
            this.labelStaticProgrammversion.Name = "labelStaticProgrammversion";
            this.labelStaticProgrammversion.Size = new System.Drawing.Size(91, 13);
            this.labelStaticProgrammversion.TabIndex = 2;
            this.labelStaticProgrammversion.Text = "Programmversion:";
            // 
            // labelDynamicProgrammversion
            // 
            this.labelDynamicProgrammversion.AutoSize = true;
            this.labelDynamicProgrammversion.Location = new System.Drawing.Point(105, 415);
            this.labelDynamicProgrammversion.Name = "labelDynamicProgrammversion";
            this.labelDynamicProgrammversion.Size = new System.Drawing.Size(88, 13);
            this.labelDynamicProgrammversion.TabIndex = 3;
            this.labelDynamicProgrammversion.Text = "Programmversion";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDynamicProgrammversion);
            this.Controls.Add(this.labelStaticProgrammversion);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormInfo";
            this.Text = "Programminformationen";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label labelStaticProgrammversion;
        private System.Windows.Forms.Label labelDynamicProgrammversion;
    }
}