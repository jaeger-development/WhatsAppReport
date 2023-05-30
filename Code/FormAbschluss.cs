/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WhatsAppReport
{
    public partial class FormAbschluss : Form
    {
        public FormAbschluss()
        {
            InitializeComponent();
        }


        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            if (checkBoxNutzungsbedingungen.Checked)
            {
                OpenArbeitsverzeichnis();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sie müssen die Nutzungsbedingungen akzeptieren oder abbrechen.");
            }

        }

        private void buttonAbbruch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenArbeitsverzeichnis()
        {
                Process.Start("explorer.exe", Global.Arbeitsverzeichnis);
        }

        private void linkLabelNutzungsbedingungen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string rtfPath = Path.Combine(Application.StartupPath, "nutzungsbedingungen.rtf");
            if (File.Exists(rtfPath))
            {
                Process.Start(rtfPath);
            }
            else
            {
                MessageBox.Show("Die Nutzungsbedingungen konnten nicht geöffnet werden, bitte setzen Sie sich vor Nutzung des Programms mit dem Entwickler in Verbindung!");
            }
        }
    }
}
