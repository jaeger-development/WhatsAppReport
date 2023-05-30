/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */
 
namespace WhatsAppReport
{
    partial class FormWartehinweis
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
            this.progressBarInfo = new System.Windows.Forms.ProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarInfo
            // 
            this.progressBarInfo.Location = new System.Drawing.Point(49, 92);
            this.progressBarInfo.Name = "progressBarInfo";
            this.progressBarInfo.Size = new System.Drawing.Size(343, 33);
            this.progressBarInfo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarInfo.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(93, 44);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(232, 20);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Auswertung läuft, bitte warten...";
            // 
            // FormWartehinweis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 177);
            this.ControlBox = false;
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.progressBarInfo);
            this.Name = "FormWartehinweis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormWartehinweis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarInfo;
        private System.Windows.Forms.Label labelInfo;
    }
}