using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppReport
{
    public partial class FormNutzungsbedingungen : Form
    {
        public FormNutzungsbedingungen()
        {
            InitializeComponent();
        }

        private void FormNutzungsbedingungen_Load(object sender, EventArgs e)
        {

            string rtfFileName = "nutzungsbedingungen.rtf"; // Name der RTF-Datei
            string exeDirPath = AppDomain.CurrentDomain.BaseDirectory; // Pfad zum Verzeichnis der .exe-Datei
            string rtfFilePath = Path.Combine(exeDirPath, rtfFileName); // Kombinieren Sie die beiden Pfade

            if (File.Exists(rtfFilePath))
            {
                // Öffnen Sie die RTF-Datei und lesen Sie ihren Inhalt
                string rtfContent = File.ReadAllText(rtfFilePath);

                // Laden Sie den Inhalt in die Text-Eigenschaft der RichTextBox
                richTextBoxNutzungsbedingungen.Rtf = rtfContent;

                // Innere Ränder festlegen

            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
