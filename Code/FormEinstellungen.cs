using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppReport
{
    public partial class FormEinstellungen : Form
    {


        public FormEinstellungen()
        {
            InitializeComponent();
        }

        private void FormEinstellungen_Load(object sender, EventArgs e)
        {
            numericUpDownReportSchriftgroesseTitel.Value = Global.ReportSchriftgroesseTitel;
            numericUpDownReportSchriftgroesseUeberschrift.Value = Global.ReportSchriftgroesseUeberschrift; 
            numericUpDownReportSchriftgroesseText.Value = Global.ReportSchriftgroesseText;
            numericUpDownChatprotokollMaxBildbreite.Value = Global.ChatprotokollMaxBildbreite;
            numericUpDownChatprotokollMaxBildhoehe.Value = Global.ChatprotokollMaxBildhoehe;
            numericUpDownChatprotokollMaxEmoticonbreite.Value = Global.ChatprotokollMaxEmoticonbreite;
            numericUpDownChatprotokollMaxEmoticonhoehe.Value = Global.ChatprotokollMaxEmoticonhoehe;

            checkBoxShowMenuDebug.Checked = Global.ShowDebugMenu;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            // Speichere Variablen

            Global.WriteRegistryValue("ReportSchriftgroesseTitel", numericUpDownReportSchriftgroesseTitel.Value, RegistryValueKind.String);
            Global.WriteRegistryValue("ReportSchriftgroesseUeberschrift", numericUpDownReportSchriftgroesseUeberschrift.Value, RegistryValueKind.String);
            Global.WriteRegistryValue("ReportSchriftgroesseText", numericUpDownReportSchriftgroesseText.Value, RegistryValueKind.String);
            Global.WriteRegistryValue("ChatprotokollMaxBildbreite", numericUpDownChatprotokollMaxBildbreite.Value, RegistryValueKind.String);
            Global.WriteRegistryValue("ChatprotokollMaxBildhoehe", numericUpDownChatprotokollMaxBildhoehe.Value, RegistryValueKind.String);
            Global.WriteRegistryValue("ChatprotokollMaxEmoticonbreite", numericUpDownChatprotokollMaxEmoticonbreite.Value, RegistryValueKind.String);
            Global.WriteRegistryValue("ChatprotokollMaxEmoticonhoehe", numericUpDownChatprotokollMaxEmoticonhoehe.Value, RegistryValueKind.String);
            
            if (checkBoxShowMenuDebug.Checked)
            {
                Global.WriteRegistryValue("ShowDebugMenu", true, RegistryValueKind.String);
            }
            else
            {
                Global.WriteRegistryValue("ShowDebugMenu", false, RegistryValueKind.String);
            }
            
            // Lade Variablen neu

            Global.LadeGlobaleVariablen();

            this.Close();
        }

        private void buttonAbbruch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
