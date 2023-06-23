/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Security.Cryptography;
using System.Web;
using System.Reflection;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;
using File = System.IO.File;
using Version = System.Version;

namespace WhatsAppReport
{
    public class Global
    {
        // Konstanten

            public const string RegKeyPath = "Software\\WhatsAppReport";


        // Variablen

        // Verzeichnisse
            public static string ApplicationPath = Application.StartupPath;
            public static string TemplatePath = Path.Combine(ApplicationPath, "Templates");
            public static string LogfilePath = Path.Combine(ApplicationPath, "Logfiles");

            // Allgemein
            public static string Auswertungsdatei;
            public static string Arbeitsverzeichnis;
            public static string Anlagenverzeichnis;
            public static string Kommunikationsprotokoll;
            public static string Annex;
            public static string Logfile;
            public static string OperationID;
            public static string[] TemporaereVerzeichnisse = new string[0];
            public static string[] DateiAnhaenge = new string[0];
            public static string[] Absender = new string[0];
            public static string osType;
            public static uint AnzahlNachrichten = 0;
            public static uint AnzahlLinks = 0;
            public static uint AnzahlBilder = 0;
            public static uint AnzahlGeloeschteDateien = 0;
            public static string ProgramVersion;

            // Einstellungen

                // Userdata
                public static string AuswertungBehoerde;
                public static string AuswertungDienststelle;
                public static string AuswertungSachbearbeiter;

                // Layout
                public static uint ReportSchriftgroesseTitel;
                public static uint ReportSchriftgroesseUeberschrift;
                public static uint ReportSchriftgroesseText;
                public static uint ChatprotokollMaxBildbreite;
                public static uint ChatprotokollMaxBildhoehe;
                public static uint ChatprotokollMaxEmoticonbreite;
                public static uint ChatprotokollMaxEmoticonhoehe;

                // Debug
                public static bool ShowDebugMenu;


        public static void WriteRegistryValue(string keyName, object keyValue, RegistryValueKind valueKind)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(Global.RegKeyPath))
                {
                    key?.SetValue(keyName, keyValue, valueKind);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Schreiben des Registry-Werts: " + ex.Message);
            }
        }

        public static string ReadRegistryValue(string keyName)
        {
            string value = null;

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Global.RegKeyPath))
                {
                    if (key != null)
                    {
                        value = key.GetValue(keyName) as string;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen des Registry-Werts: " + ex.Message);
            }

            return value;
        }

        public static void LadeGlobaleVariablen()
        {

            // Lade aus Registry

                // String-Werte
                    Global.AuswertungBehoerde = ReadRegistryValue("AuswertungBehoerde");
                    Global.AuswertungDienststelle = ReadRegistryValue("AuswertungDienststelle");
                    Global.AuswertungSachbearbeiter = ReadRegistryValue("AuswertungSachbearbeiter");

                // UInt-Werte
                    string ReportSchriftgroesseTitel = ReadRegistryValue("ReportSchriftgroesseTitel");
                    if (UInt32.TryParse(ReportSchriftgroesseTitel, out uint ausgabe0))
                    {
                        Global.ReportSchriftgroesseTitel = ausgabe0;
                    }

                    string ReportSchriftgroesseUeberschrift = ReadRegistryValue("ReportSchriftgroesseUeberschrift");
                    if (UInt32.TryParse(ReportSchriftgroesseUeberschrift, out uint ausgabe1))
                    {
                        Global.ReportSchriftgroesseUeberschrift = ausgabe1;
                    }

                    string ReportSchriftgroesseText = ReadRegistryValue("ReportSchriftgroesseText");
                    if (UInt32.TryParse(ReportSchriftgroesseText, out uint ausgabe2))
                    {
                        Global.ReportSchriftgroesseText = ausgabe2;
                    }

                    string ChatprotokollMaxBildbreite = ReadRegistryValue("ChatprotokollMaxBildbreite");
                    if (UInt32.TryParse(ChatprotokollMaxBildbreite, out uint ausgabe3))
                    {
                        Global.ChatprotokollMaxBildbreite = ausgabe3;
                    }

                    string ChatprotokollMaxBildhoehe = ReadRegistryValue("ChatprotokollMaxBildhoehe");
                    if (UInt32.TryParse(ChatprotokollMaxBildhoehe, out uint ausgabe4))
                    {
                        Global.ChatprotokollMaxBildhoehe = ausgabe4;
                    }
                    string ChatprotokollMaxEmoticonbreite = ReadRegistryValue("ChatprotokollMaxEmoticonbreite");
                    if (UInt32.TryParse(ChatprotokollMaxEmoticonbreite, out uint ausgabe5))
                    {
                        Global.ChatprotokollMaxEmoticonbreite = ausgabe5;
                    }

                    string ChatprotokollMaxEmoticonhoehe = ReadRegistryValue("ChatprotokollMaxEmoticonhoehe");
                    if (UInt32.TryParse(ChatprotokollMaxEmoticonhoehe, out uint ausgabe6))
                    {
                        Global.ChatprotokollMaxEmoticonhoehe = ausgabe6;
                    }

                    string ShowDebugMenu = ReadRegistryValue("ShowDebugMenu");
                    if (Boolean.TryParse(ShowDebugMenu, out bool ausgabe7))
                    {
                        Global.ShowDebugMenu = ausgabe7;
                    }


            // Sonstige Werte

            ProgramVersion = Application.ProductVersion;
        }



        // Bereich Vorbereitung

        public static void ZaehlerZuruecksetzen()
        {
            DateiAnhaenge = new string[0];
            Absender = new string[0];
            AnzahlNachrichten = 0;
            AnzahlLinks = 0;
            AnzahlBilder = 0;
            AnzahlGeloeschteDateien = 0;
            osType = "";
            OperationID = "";
        }

        public static void AuswertungStarten()
        {
            //Variablen für Statistikauswertung neu setzen
            ZaehlerZuruecksetzen();

            // Eindeutige ID für Vorgang erzeugen
            OperationID = SetOperationID();
            
            // Logfile anlegen
            CreateLogfile();

            // Arbeitsverzeichnis festlegen
            SetzeArbeitsverzeichnis();

            // Arbeitsverzeichnis in Temporäre Verzeichnisse speichern, um sie später wieder löschen zu können
            ArbeitsverzeichnisFuerLoeschungZwischenspeichern();

            // Dateien anlegen
            CreateKommunikationsprotokollFile();
        }

        public static string SetOperationID()
        {
            // OperationID
            return  DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public static void SetzeArbeitsverzeichnis()
        {
            // Temporäres Verzeichnis abrufen
            string tempPath = Path.GetTempPath();

            string Dateiname = string.Concat("WhatsApp-Auswertung-", OperationID);

            // Arbeitsverzeichnis basierend auf Datum und Uhrzeit erstellen und in Variablen speichern
            Arbeitsverzeichnis = Path.Combine(tempPath, Dateiname);
            Directory.CreateDirectory(Arbeitsverzeichnis);
            WriteLog("Arbeitsverzeichnis gesetzt: " + Arbeitsverzeichnis);

            // Anlagenverzeichnis erstellen und in Variablen speichern
            Anlagenverzeichnis = Path.Combine(Arbeitsverzeichnis, "Anlagen");
            Directory.CreateDirectory(Anlagenverzeichnis); 
            WriteLog("Anlagenverzeichnis gesetzt: " + Anlagenverzeichnis);
        }

        public static void CreateKommunikationsprotokollFile()
        {
            // Pfad zur Textdatei erstellen
            Global.Kommunikationsprotokoll = Path.Combine(Global.Arbeitsverzeichnis, "kommunikationsprotokoll.html");

            // Textdatei erstellen oder überschreiben
            string htmlKopf = $"<!DOCTYPE html><html><head><title>Chatverlauf</title><style>body {{font-family: Calibri, Arial, sans-serif; font-size: {Global.ReportSchriftgroesseText}px; }} .titel {{font-size: {Global.ReportSchriftgroesseTitel}px; font-weight: bold; margin-bottom: 10px; }}.ueberschrift {{font-size: {Global.ReportSchriftgroesseUeberschrift}px; font-weight: bold; margin-bottom: 10px; }} .bild {{ width: {Global.ChatprotokollMaxBildbreite}px; max-height: {Global.ChatprotokollMaxBildhoehe}px; object-fit: cover; }} .emoticon {{ width: {Global.ChatprotokollMaxEmoticonbreite}px; max-height: {Global.ChatprotokollMaxEmoticonhoehe}px; object-fit: cover; }} </style></head><body><div class=\"titel\">Chatverlauf</div>";
            
            File.AppendAllText(Global.Kommunikationsprotokoll, htmlKopf);

            // Logfileeintrag
            WriteLog("Kommunikationsprotokoll angelegt: " + Kommunikationsprotokoll);
        }

        public static void CreateLogfile()
        {
            // Pfad zur Textdatei erstellen
            string logfilename = OperationID + ".txt";
            Logfile = Path.Combine(LogfilePath, logfilename);

            // Textdatei erstellen oder überschreiben
            string line = "Logfile für Auswertung: " + OperationID + Environment.NewLine;
            try
            {
                File.AppendAllText(Logfile, line);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void MoveToAttachments(string Quelldatei)
        {
            // Info: Quelldatei wird als ganzer Pfad zur Datei übergeben
            string Zieldatei = Path.Combine(Anlagenverzeichnis, Path.GetFileName(Quelldatei));

            try
            {
                WriteLog("Versuche, die Datei " + Quelldatei + " nach " + Zieldatei + " zu verschieben");
                File.Move(Quelldatei, Zieldatei);
            }
            catch (Exception ex)
            {
                WriteLog("Fehler beim Verschieben der Anlage " + Quelldatei + ": " + ex);
            }

        }






        // Bereich Allgemein

        public static void ArbeitsverzeichnisFuerLoeschungZwischenspeichern()
        {
            Array.Resize(ref TemporaereVerzeichnisse, TemporaereVerzeichnisse.Length + 1);
            TemporaereVerzeichnisse[TemporaereVerzeichnisse.Length - 1] = Global.Arbeitsverzeichnis;
        }

        public static void WriteLog(string Eintrag)
        {
            File.AppendAllText(Logfile, Eintrag + Environment.NewLine);
        }

        public static void FillFieldInAnnex(string fieldName, string value)
        {
            // Erstelle eine Instanz von Microsoft Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            // Öffne das DOTX-Dokument
            Document doc = wordApp.Documents.Open(Annex);

            // Aktiviere das Dokument
            doc.Activate();

            // Durchsuche alle Felder im Dokument
            foreach (Field field in doc.Fields)
            {
                // Überprüfe, ob das Feld den gesuchten Feldnamen enthält
                if (field.Code.Text.Contains(fieldName))
                {
                    // Ersetze das Feld durch den Wert
                    field.Select();
                    wordApp.Selection.TypeText(value);
                }
            }

            // Speichere und schließe das Dokument
            doc.Save();
            doc.Close();

            // Beende die Word-Anwendung
            wordApp.Quit();
        }



        // Bereich Verarbeitung

        public static void OpenChatFile()
        {
            WriteLog("Versuche, die Chat-Datei zu bestimmen!");
            // Versuch der automatischen Bestimmung
          
            try
            {
                // Prüfe, ob eine Datei im Ordner "folderPath" existiert, die den gewünschten Kriterien entspricht
                bool iosFileExists = Directory.GetFiles(Arbeitsverzeichnis)
                                         .Any(Arbeitsverzeichnis => Path.GetFileName(Arbeitsverzeichnis).StartsWith("_chat")
                                                          && Path.GetExtension(Arbeitsverzeichnis).Equals(".txt"));

                bool androidFileExists = Directory.GetFiles(Arbeitsverzeichnis)
                         .Any(Arbeitsverzeichnis => Path.GetFileName(Arbeitsverzeichnis).StartsWith("WhatsApp-Chat")
                                          && Path.GetExtension(Arbeitsverzeichnis).Equals(".txt"));


                // Überprüfe, ob die Datei existiert
                if (iosFileExists)
                {
                    // Prüfen, ob eine in Frage kommende Chat-Datei existiert
                    string sourceFilePath = Directory.GetFiles(Arbeitsverzeichnis)
                                                    .FirstOrDefault(Arbeitsverzeichnis => Path.GetFileName(Arbeitsverzeichnis).StartsWith("_chat")
                                                                               && Path.GetExtension(Arbeitsverzeichnis).Equals(".txt"));

                    Auswertungsdatei = sourceFilePath;
                    VerarbeiteChatFile(Auswertungsdatei);
                }
                else if (androidFileExists)
                {
                    // Prüfen, ob eine in Frage kommende Chat-Datei existiert
                    string sourceFilePath = Directory.GetFiles(Arbeitsverzeichnis)
                                                    .FirstOrDefault(Arbeitsverzeichnis => Path.GetFileName(Arbeitsverzeichnis).StartsWith("WhatsApp-Chat")
                                                                               && Path.GetExtension(Arbeitsverzeichnis).Equals(".txt"));

                    Auswertungsdatei = sourceFilePath;
                    VerarbeiteChatFile(Auswertungsdatei);
                }
                else
                {
                    MessageBox.Show("Die Chat-Datei konnte nicht automatisch bestimmt werden, Du kannst aber versuchen, den Chat manuell zu öffnen!");
                    return;
                }
            }
            catch (Exception ex)
            {
                // Fehlermeldung anzeigen
                MessageBox.Show($"Fehler beim Bestimmen der Chat-Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CheckWhatsAppOS()
        {
            string[] zipFiles = Directory.GetFiles(Arbeitsverzeichnis, "WhatsApp*.zip");

            if (zipFiles.Length > 0)
            {
                string zipFileName = zipFiles[0];
                string extractPath = Arbeitsverzeichnis;

                ZipFile.ExtractToDirectory(zipFileName, extractPath);
                osType = "ios";
                WriteLog("osType festgelegt auf: " + osType + "; Zip-Archiv ins Arbeitsverzeichnis entpackt");

                OpenChatFile();
            }
            else
            {
                osType = "android";
                WriteLog("osType festgelegt auf: " + osType);

                OpenChatFile();
            }
        }

        public static void VerarbeiteChatFile(string chatFile)
        {
            WriteLog("An Verarbeitung übergebene Chatfile: " + chatFile);

            try
            {
                // Überprüfe, ob die Datei existiert
                if (File.Exists(chatFile))
                {
                    string fullChat = File.ReadAllText(chatFile);

                    // osType wird in CheckWhatsAppOS festgelegt auf "android" oder "ios"
                    if (osType == "ios")
                    {
                        IOS.ExtractMessage(fullChat);
                    }
                    else if (osType == "android")
                    {
                        Android.ExtractMessage(fullChat);
                    }

                }
                Global.AuswertungAbschliessen();
            }
            catch (Exception ex)
            {
                // Fehlermeldung anzeigen
                WriteLog("Fehler bei der Verarbeitung der Chatdatei: " + ex.Message);
                MessageBox.Show("Kritischer Fehler, die Auswertung konnte nicht abgeschlossen werden.");
            }
        }

        public static void WriteToKommunikationsprotokoll(string myTimestamp, string mySender, string myMessage)
        {
            // Zeile erstellen mit den übergebenen Variablen
            string line = myTimestamp + mySender + myMessage;

            // Anzahl der AnzahlNachrichten für Auswertung hochzählen
            Global.AnzahlNachrichten++; 

            // Namen der Absender für spätere Auswertung speichern
            Array.Resize(ref Global.Absender, Global.Absender.Length + 1);
            Global.Absender[Global.Absender.Length - 1] = mySender;

            // Zeile in Textdatei anhängen
            File.AppendAllText(Global.Kommunikationsprotokoll, line + Environment.NewLine);
        }

        public static string DateiEinbindung(string Dateiname)
        {
            // Regulärer Ausdruck für die Suche nach versteckten Zeichen
            string pattern = @"[\p{C}]";

            // Entfernung von versteckten Zeichen
            Dateiname = Regex.Replace(Dateiname, pattern, string.Empty);

            // Namen der Dateianhänge für spätere Auswertung speichern                -------------------------    !!!auslagern!!!
            Array.Resize(ref Global.DateiAnhaenge, Global.DateiAnhaenge.Length + 1);
            Global.DateiAnhaenge[Global.DateiAnhaenge.Length - 1] = Dateiname;

            WriteLog("Prüfe Dateianhang: " + Dateiname);
            string Datei = Path.Combine(Arbeitsverzeichnis, Dateiname);

            if (IsAcceptedFileType(Dateiname))
            {
                WriteLog("Dateianhang erlaubt, Datei wird in Anlagen verschoben und eingebunden"); 
                MoveToAttachments(Datei);

                if (IsImageFile(Dateiname))
                {
                    if (IsEmoticon(Dateiname))
                    {
                        // zusätzlich Anzahl der Bilddateien für spätere Auswertung speichern
                        Global.AnzahlBilder++;

                        string ausgabe = $"<a href=\"Anlagen\\{Dateiname}\" target=_blank><img class=\"emoticon\" src=\"Anlagen\\{Dateiname}\"></a>";
                        return ausgabe;

                    }
                    else
                    {
                        // zusätzlich Anzahl der Bilddateien für spätere Auswertung speichern
                        Global.AnzahlBilder++;

                        string ausgabe = $"<a href=\"Anlagen\\{Dateiname}\" target=_blank><img class=\"bild\" src=\"Anlagen\\{Dateiname}\"></a>";
                        return ausgabe;

                    }
                }
                else
                {
                    string ausgabe = $"<a href=\"Anlagen\\{Dateiname}\" target=_blank>{Dateiname}</a>";

                    return ausgabe;
                }
            }
            else
            {
                WriteLog("Dateianhang nicht erlaubt, Datei wird umbenannt");
                string sichererDateiname = Dateiname + ".gesperrt";
                string gesperrteDatei = Path.Combine(Arbeitsverzeichnis, sichererDateiname);

                if (RenameFile(Datei, gesperrteDatei)) //deaktiviert verschiedene Autoruns durch Umbenennung
                {
                    //umbenannte Datei in Anlagen verschieben
                    MoveToAttachments(gesperrteDatei);

                    WriteLog("Datei umbenannt und verschoben");
                    string ausgabe = $"<b><font color=\"red\">*** Die Nachricht enthielt eine Datei, die aus Sicherheitsgründen nicht eingebunden wurde: {Dateiname} ***</font></b>";

                    return ausgabe;
                }
                else
                {
                    WriteLog("Datei konnte nicht umbenannt werden, Einbindung blockiert");
                    string ausgabe = $"<b><font color=\"red\">*** Die Nachricht enthielt eine Datei, die aus Sicherheitsgründen nicht eingebunden wurde: {Dateiname} ***</font></b>";

                    return ausgabe;
                }

            }
        }

        public static string FormatiereLink(string url)
        {
            return "<a href=\"" + url + "\" target=_blank>" + url + "</a>";
        }

        public static bool IsImageFile(string filename)
        {
            // Regulärer Ausdruck für die Überprüfung der Dateierweiterung
            string pattern = @"\.(?i)(jpg|jpeg|png|gif|bmp|webp)$";

            // Regex.IsMatch, um zu überprüfen, ob der Dateiname die gewünschte Dateierweiterung hat
            return Regex.IsMatch(filename, pattern);
        }

        public static bool IsEmoticon(string filename)
        {
            // Regulärer Ausdruck für die Überprüfung der Dateierweiterung
            string pattern = @"\.(?i)(webp)$";

            // Regex.IsMatch, um zu überprüfen, ob der Dateiname die gewünschte Dateierweiterung hat
            return Regex.IsMatch(filename, pattern);
        }

        public static bool IsAcceptedFileType(string filename)
        {
            // Regulärer Ausdruck für die Überprüfung der Dateierweiterung
            string pattern = @"\.(?i)(jpg|opus|webp)$";

            // Regex.IsMatch, um zu überprüfen, ob der Dateiname die gewünschte Dateierweiterung hat
            return Regex.IsMatch(filename, pattern);
        }

        public static bool RenameFile(string oldName, string newName)
        {
            try
            {
                File.Move(oldName, newName);
                return true;
            }
            catch (Exception e)
            {
                WriteLog($"Fehler beim Umbenennen der Datei: {e.Message}");
                return false;
            }
        }

        public static string ExtractUrl(string input)
        {
            // Regulärer Ausdruck für die Erkennung von URLs
            string pattern = @"(https?://[\w.\-/_?=,]+)";

            // Regex.Match, um die erste Übereinstimmung mit dem Muster zu finden
            Match match = Regex.Match(input, pattern);

            // Überprüfen, ob eine Übereinstimmung gefunden wurde
            if (match.Success)
            {
                // Die URL aus der Übereinstimmung extrahieren und zurückgeben
                return match.Groups[1].Value;
            }

            // Wenn keine Übereinstimmung gefunden wurde, einen leeren String zurückgeben
            return string.Empty;
        }

        public static string[] CheckForAttachments(string input, string[] keywords)
        {
            // Ergebnis-Liste für gefundene Suchbegriffe
            List<string> foundKeywordsList = new List<string>();

            // Durchsuchen der Eingabe nach den Suchbegriffen
            foreach (string keyword in keywords)
            {
                if (input.Contains(keyword))
                {
                    foundKeywordsList.Add(keyword); // Hinzufügen des gefundenen Suchbegriffs zur Ergebnis-Liste
                }
            }

            // Löschen von Duplikaten aus der Ergebnis-Liste
            List<string> distinctKeywordsList = foundKeywordsList.Distinct().ToList();

            // Rückgabe der gefundenen Suchbegriffe als Array
            if (distinctKeywordsList.Count > 0)
            {
                return distinctKeywordsList.ToArray();
            }
            else
            {
                return null; // Rückgabe von null, wenn keine Suchbegriffe gefunden wurden
            }
        } // Überprüfung ob es im Nachrichteninhalt Hinweise auf Dateianhänge gibt; falls ja, werden die Art der Anhänge in einem Array zurückgegeben

        public static string ExtractFilename(string nachricht)
        {
            // Wenn ein Dateiname bestätigt werden kann, wird dieser zurückgegeben, ansonsten Null

            string Dateiname = nachricht;

            return Dateiname;

        } // Noch Dummy-Funktion

        public static string GetFileExtension(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return string.Empty;
            }

            int extensionIndex = filePath.LastIndexOf('.');
            if (extensionIndex < 0)
            {
                return string.Empty;
            }

            return filePath.Substring(extensionIndex + 1);
        }




        // Bereich Nachbereitung

        public static void CreateAnnex()
        {
            // Kopiere die Vorlagendatei in das Arbeitsverzeichnis 
            string sourceFile = Path.Combine(TemplatePath, "Anlage.docx");
            WriteLog("Versuche, die Anlagenvorlage " + sourceFile + " ins Arbeitsverzeichnis zu kopieren");

            Annex = Path.Combine(Arbeitsverzeichnis, "Anlage.docx");
            WriteLog("Target:" + Annex);

            File.Copy(sourceFile, Annex);
            WriteLog("Die Anlage wurde ins Arbeitsverzeichnis kopiert.");

            Absender = Absender.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Absender = Absender.Distinct().ToArray();

            WriteLog("Erstelle Inhalte der Anlage...");

            
            // Befülle die Felder
            FillFieldInAnnex("Behoerde",AuswertungBehoerde);
            FillFieldInAnnex("Dienststelle", AuswertungDienststelle);
            FillFieldInAnnex("Sachbearbeiter", AuswertungSachbearbeiter);
            FillFieldInAnnex("AnzahlAbsender", Absender.Length.ToString());
            FillFieldInAnnex("AnzahlDateien", DateiAnhaenge.Length.ToString());
            FillFieldInAnnex("AnzahlNachrichten", AnzahlNachrichten.ToString());
        }

        public static void AuswertungAbschliessen()
        {
            // Kommunikationsprotokoll abschließen
            string htmlFuss = "</body></html>";
            File.AppendAllText(Global.Kommunikationsprotokoll, htmlFuss);

            // Anlage zur Auswertung anlegen
            CreateAnnex();

            // Alle Dateien außer Berichten im Arbeitsverzeichnis löschen
            CleanupArbeitsverzeichnis();

            // Abschlussform öffnen
            FormAbschluss formAbschluss = new FormAbschluss();
            formAbschluss.ShowDialog();
        }

        public static void LoescheTemporaereVerzeichnisse()
        {
            try
            {
                foreach (string Verzeichnis in TemporaereVerzeichnisse)
                {
                    if (Directory.Exists(Verzeichnis))
                    {
                        Directory.Delete(Verzeichnis, true);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Fehler beim Löschen der temporären Verzeichnisse: " + ex);
            }

        }

        public static void CleanupArbeitsverzeichnis()
        {
            string[] excludedFiles = {
                Path.GetFileName(Kommunikationsprotokoll),
                Path.GetFileName(Annex)
            };

            DirectoryInfo Quellverzeichnis = new DirectoryInfo(Arbeitsverzeichnis);

            FileInfo[] Dateien = Quellverzeichnis.GetFiles();

            WriteLog("Räume Arbeitsverzeichnis auf...");

            // Loop through all files in the source directory
            foreach (FileInfo Datei in Dateien)
            {
                // Check if the current file should be excluded
                if (!excludedFiles.Contains(Datei.Name))
                {
                    try
                    {
                        Datei.Delete();
                        WriteLog("Gelöscht: " + Datei);
                    }
                    catch (Exception ex)
                    {
                        WriteLog("Die Datei " + Datei + " konnte nicht gelöscht werden! Fehler: " + ex.Message);
                    }
                }
            }
        }
    }
}
