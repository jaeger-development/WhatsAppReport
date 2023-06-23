/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */

using System;
using System.IO;
using File = System.IO.File;
using Directory = System.IO.Directory;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;
using static System.Net.WebRequestMethods;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using Application = System.Windows.Forms.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.IO.Compression;
using System.Web;
using System.Reflection;

namespace WhatsAppReport
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "WhatsAppReport " + Global.ProgramVersion;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Global.LadeGlobaleVariablen();
            
            // DebugMenü nur anzeigen wenn in Einstellungen aktiviert
            MenuItemDebug.Visible = Global.ShowDebugMenu;

            // Infofenster
            string KurzInfo = Path.Combine(Global.ApplicationPath, "kurzinfo-main.rtf");

            if (File.Exists(KurzInfo))
            {
                // Öffnen Sie die RTF-Datei und lesen Sie ihren Inhalt
                richTextBoxKurzinfo.Rtf = File.ReadAllText(KurzInfo);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.LoescheTemporaereVerzeichnisse();
        }



        // Bereich Programmbedienung

        private void MenuItemLadeEMail_Click(object sender, EventArgs e)
        {
            LoadEMail();
        }

        private void MenuItemLadeDatei_Click(object sender, EventArgs e)
        {
            // Chatfile öffnen
            string Datei = ChooseChatFile();

            // Null, wenn Benutzer abbricht
            if (Datei != null)
            {
                Global.AuswertungStarten();

                // Prüfe ob ZIP(IOS) TXT(Android)
                if (Global.GetFileExtension(Datei) == "zip")
                {
                    Global.osType = "ios";

                    // Zip-Datei ins Arbeitsverzeichnis kopieren
                    File.Copy(Datei, Path.Combine(Global.Arbeitsverzeichnis, "backup.zip"), true);

                    // Zip-Datei entpacken direkt ins Verzeichnis ohne Unterverzeichnis (".")
                    ZipFile.ExtractToDirectory(Path.Combine(Global.Arbeitsverzeichnis, "backup.zip"), Global.Arbeitsverzeichnis);

                    // Bestimmen ob die ZIP in ein Unterverzeichnis entpackt wurde
                    string[] subdirectories = Directory.GetDirectories(Global.Arbeitsverzeichnis);
                    if (subdirectories.Length == 1)
                    {
                        // Unterverzeichnis in Arbeitsverzeichnis kopieren und Unterverzeichnis löschen
                        string subdirectoryPath = subdirectories[0];
                        CopyDirectory(subdirectoryPath, Global.Arbeitsverzeichnis);
                        try
                        {
                            foreach (string file in Directory.GetFiles(subdirectoryPath))
                            {
                                File.Delete(file);
                            }
                            Directory.Delete(subdirectoryPath);

                            File.Delete(Path.Combine(Global.Arbeitsverzeichnis, "backup.zip"));
                        }
                        catch
                        {

                        }
                    }

                    //Chatfile öffnen
                    Global.OpenChatFile();

                }
                else if (Global.GetFileExtension(Datei) == "txt")
                {

                    Global.osType = "android";

                    // Verzeichnis bestimmen
                    string Verzeichnis = Path.GetDirectoryName(Datei);

                    //Gesamtes Verzeichnis ins Arbeitsverzeichnis kopieren
                    CopyDirectory(Verzeichnis, Global.Arbeitsverzeichnis);

                    //Chatfile öffnen
                    Global.OpenChatFile();
                }
                else
                {
                    // Fehler
                    return;
                }
            }
        }

        private void MenuItemEinstellungen_Click(object sender, EventArgs e)
        {
            FormEinstellungen formEinstellungen = new FormEinstellungen();
            formEinstellungen.ShowDialog();
        }

        private void MenuItemNutzungsbedingungen(object sender, EventArgs e)
        {
            FormNutzungsbedingungen formNutzungsbedingungen = new FormNutzungsbedingungen();
            formNutzungsbedingungen.Show();
        }

        private void MenuItemLizenzinfo(object sender, EventArgs e)
        {
            FormLizenz formLizenz = new FormLizenz();
            formLizenz.ShowDialog();
        }

        private void MenuItemHilfe_Click(object sender, EventArgs e)
        {
            string hilfe = "hilfe.chm"; // Ersetzen Sie den Pfad entsprechend Ihren Anforderungen
            Help.ShowHelp(this, hilfe);
        }

        private void MenuItemProgramminfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void MenuItemBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoadEMail_Click(object sender, EventArgs e)
        {
            LoadEMail();
        }



        // Bereich Debug

        private void MenuItemOpenWorkFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Global.Arbeitsverzeichnis);
        }

        private void MenuItemOpenLogFolder_Click(object sender, EventArgs e)
        {
            string Logverzeichnis = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Log");
            System.Diagnostics.Process.Start("explorer.exe", Logverzeichnis);
        }



        // Bereich Mail von Outlook

        public static void LoadEMail()
        {
            // E-Mail öffnen
            Outlook.MailItem MailFile = OpenMailFile();

            // Null, wenn Benutzer abbricht
            if (MailFile != null)
            {
                Global.AuswertungStarten();

                // Extrahiere Anlagen
                ExtractAttachmentsFromOutlookEmail(MailFile);
            }
        }

        public static Outlook.MailItem OpenMailFile()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                // Titel und Startverzeichnis für den Dialog setzen
                openFileDialog.Title = "E-Mail öffnen";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Filter für Dateitypen setzen
                openFileDialog.Filter = "Outlook E-Mails (*.msg)|*.msg";

                // Dialog anzeigen und ausgewählten Dateipfad abfragen
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        // Ausgewählten Dateipfad abrufen
                        string selectedFilePath = openFileDialog.FileName;

                        // Outlook-Anwendung erstellen
                        Outlook.Application outlookApp = new Outlook.Application();

                        // Namespace für Outlook-Mails erstellen
                        Outlook.NameSpace outlookNamespace = outlookApp.GetNamespace("MAPI");

                        // MailItem aus der ausgewählten Datei öffnen
                        Outlook.MailItem mailItem = (Outlook.MailItem)outlookNamespace.OpenSharedItem(selectedFilePath);

                        // Rückgabewert mit MailItem-Objekt
                        return mailItem;
                    }
                    catch (System.Runtime.InteropServices.COMException ex)
                    {
                        // Fehlermeldung anzeigen
                        Global.WriteLog("Die E-Mail konnte nicht geöffnet werden: " + ex);
                        MessageBox.Show("Die E-Mail konnte nicht geöffnet werden, möglichweise greifen noch andere Programme darauf zu. Schließe bitte alle geöffneten Anwendungen und Dateien und versuch es erneut.");
                        return null;
                    }
                }
                else
                {
                    // Rückgabewert für Abbruch oder Fehlerfall
                    return null;
                }
            }
        }

        private static void ExtractAttachmentsFromOutlookEmail(Outlook.MailItem mailItem)
        {
            Global.WriteLog("E-Mail geöffnet");
            foreach (Outlook.Attachment attachment in mailItem.Attachments)
            {
                attachment.SaveAsFile(Path.Combine(Global.Arbeitsverzeichnis, attachment.FileName));
                Global.WriteLog("Mailanlage im Arbeitsverzeichnis gespeichert: " + attachment.FileName);
            }

            //Übergabe zur Prüfung auf welchem Betriebssystem WhatsApp ausgeführt wurde
            Global.CheckWhatsAppOS();
        }



        // Bereich Verzeichnis

        public static string ChooseChatFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "WhatsApp-Chat auswählen",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "WhatsApp Dateien (*.zip, *.txt)|*.zip;*.txt",
                FilterIndex = 0,
                RestoreDirectory = true,
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                return selectedFilePath;
            }
            else
            {
                return null;
            }
        }

        public static void CopyDirectory(string sourceDirPath, string destinationDirPath)
        {
            // Create the destination directory if it does not exist
            if (!Directory.Exists(destinationDirPath))
            {
                Directory.CreateDirectory(destinationDirPath);
            }

            // Copy all files from the source directory to the destination directory
            foreach (string filePath in Directory.GetFiles(sourceDirPath))
            {
                string fileName = Path.GetFileName(filePath);
                string destFilePath = Path.Combine(destinationDirPath, fileName);
                File.Copy(filePath, destFilePath, true);
            }

            // Copy all subdirectories recursively
            foreach (string subDirPath in Directory.GetDirectories(sourceDirPath))
            {
                string subDirName = Path.GetFileName(subDirPath);
                string destSubDirPath = Path.Combine(destinationDirPath, subDirName);
                CopyDirectory(subDirPath, destSubDirPath);
            }
        }
    }
}
