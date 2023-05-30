/*
 * Copyright [2023] [Christian Jäger]
 * Dieses Programm ist unter der GPL lizenziert.
 * Weitere Informationen finden Sie in der Lizenzdatei oder unter:
 * https://www.gnu.org/licenses/gpl-3.0.html
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppReport
{
    public class Android
    {
        public static void ExtractMessage(string fullChat)
        {
            string fullMessage;

            MatchCollection matches;

            // Das Muster "01.01.22, 12:00 - " kennzeichnet den Beginn einer neuen Nachricht
            string pattern = @"\d\d\.\d\d\.\d\d, \d\d:\d\d - ";

            do
            {
                // Überprüfe, ob der Text dem Muster entspricht
                matches = Regex.Matches(fullChat, pattern);

                // Bearbeitung je nach Anzahl der Fundstellen

                // Pattern 1x gefunden (letzte Nachricht)
                if (matches.Count == 1)
                {

                    // Selektiere die erste Nachricht aus fullChat und setze die Variable fullMessage (Text vom des ersten Treffers bis VOR dem Beginn des zweiten Treffers)
                    fullMessage = fullChat;

                    // Lösche die eben kopierte Nachricht aus fullChat
                    fullChat = "";

                    // Weiterverarbeitung
                    ParseMessage(fullMessage); // Methode für jede Nachricht aufrufen
                }

                // Pattern mindestens 2x gefunden (Normalfall bis auf die letzte Nachricht)
                else
                {

                    // Treffer markieren
                    Match firstMatch = matches[0];
                    Match secondMatch = matches[1];

                    // Selektiere die erste Nachricht aus fullChat und setze die Variable fullMessage (Text vom des ersten Treffers bis VOR dem Beginn des zweiten Treffers)
                    fullMessage = fullChat.Substring(firstMatch.Index, secondMatch.Index - firstMatch.Index - 1);

                    // Lösche die eben kopierte Nachricht aus fullChat
                    fullChat = fullChat.Remove(firstMatch.Index, secondMatch.Index - firstMatch.Index - 1);

                    // Weiterverarbeitung
                    ParseMessage(fullMessage); // Methode für jede Nachricht aufrufen
                }
            } while (matches.Count > 1);


        }

        public static void ParseMessage(string input)
        {

            int timestampEndIndex = input.IndexOf(" - "); // Index des Abschlusstextes des Zeitstempels finden

            if (timestampEndIndex != -1)
            {
                string timestampString = input.Substring(0, timestampEndIndex); // Zeitstempel-Teilstring extrahieren
                if (DateTime.TryParse(timestampString, out DateTime timestamp))
                {
                    int senderEndIndex = input.IndexOf(": "); // Index des Abschlusstextes des Absenders finden
                    if (senderEndIndex != -1)
                    {
                        // TimeStamp, Absender und Nachricht vorhanden:

                        string sender = input.Substring(timestampEndIndex + 3, senderEndIndex - timestampEndIndex - 3); // Absender-Teilstring extrahieren
                        string message = input.Substring(senderEndIndex + 2); // Nachricht-Teilstring extrahieren

                        string myTimestamp = "<br><br><b>" + timestamp.ToString("dd.MM.yyyy HH:mm") + " ";
                        string mySender = sender + "</b><br>";
                        string myMessage = message;

                        Global.WriteToKommunikationsprotokoll(myTimestamp, mySender, FormatiereNachrichteninhalt(myMessage));
                    }
                    else
                    {
                        // nur TimeStamp und Nachricht vorhanden:

                        string message = input.Substring(timestampEndIndex + 3); // Nachricht-Teilstring extrahieren

                        string myTimestamp = "<br><br><b>" + timestamp.ToString("dd.MM.yyyy HH:mm") + "</b><br>";
                        string myMessage = message;

                        Global.WriteToKommunikationsprotokoll(myTimestamp, null, FormatiereNachrichteninhalt(myMessage));
                    }
                }
                else
                {
                    Global.WriteToKommunikationsprotokoll("<br><br><b>Ungültiger Zeitstempel:", FormatiereNachrichteninhalt(input), "</b><br><br>");
                    MessageBox.Show("Ungültiger Zeitstempel gefunden, möglicherweise war der WhatsApp-Export fehlerhaft. Die Auswertung wird fortgesetzt, aber bitte prüfen Sie die Ausgabedatei genau!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Global.WriteToKommunikationsprotokoll("", input, "");
                //MessageBox.Show("Ungültiges Eingabeformat: " + input, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string FormatiereNachrichteninhalt(string Nachrichteninhalt)
        {
            string uebergabe = Nachrichteninhalt;

            // Vordefinierte Suchbegriffe
            string[] keywords = { "<Medien ausgeschlossen>", "(Datei angehängt)", "http" };

            // Überprüfung ob es im Nachrichteninhalt Hinweise auf Dateianhänge gibt; falls ja, werden die Art der Anhänge in einem Array zurückgegeben
            string[] foundKeywords = Global.CheckForAttachments(Nachrichteninhalt, keywords);

            // Überprüfen, ob Suchbegriffe gefunden wurden
            if (foundKeywords != null && foundKeywords.Length > 0)
            {
                // Code für den Fall, dass Suchbegriffe gefunden wurden

                int AnzahlAnlagen = foundKeywords.Length;

                if (AnzahlAnlagen > 1)
                {

                    // Mehr als eine Anlage in einer Nachricht, dieser Fall kann derzeit nicht verarbeitet werden! Es wird nur die Originalnachricht ausgegeben
                    MessageBox.Show("In einer Nachricht befanden sich " + AnzahlAnlagen + " Dateien, die Nachricht wurde NICHT ausgewertet sondern wird in ursprünglicher Form ausgegeben!");
                }
                else
                {
                    // Nur eine Anlage gefunden

                    // Anlagentyp bestimmen und Anlage extrahieren
                    string Anlagentyp = foundKeywords[0];

                    switch (Anlagentyp)
                    {
                        case "http": // Link in Nachricht
                            Global.AnzahlLinks++;
                            string url = Global.ExtractUrl(Nachrichteninhalt);
                            string link = Global.FormatiereLink(url);
                            uebergabe = Nachrichteninhalt.Replace(url, link);
                            break;

                        case "<Medien ausgeschlossen>":  // Gelöschte Datei in Nachricht
                            Global.AnzahlGeloeschteDateien++;
                            uebergabe = Nachrichteninhalt.Replace("<Medien ausgeschlossen>", "*** Datei nicht mehr verfügbar ***");
                            break;

                        case "(Datei angehängt)":  // Datei in Nachricht; Nachrichteninhalt kann nur den Dateinamen enthalten oder einen Dateinamen im Text
                            Nachrichteninhalt = Nachrichteninhalt.Replace(" (Datei angehängt)", String.Empty);
                            string Dateiname = Global.ExtractFilename(Nachrichteninhalt);
                            uebergabe = Nachrichteninhalt.Replace(Nachrichteninhalt, Global.DateiEinbindung(Dateiname));
                            break;

                        default:
                            // Bislang nicht bekannte Anlage in einer Nachricht gefunden, dieser Fall kann derzeit nicht verarbeitet werden! Es wird nur die Originalnachricht ausgegeben
                            MessageBox.Show("In einer Nachricht befand sich ein bislang unbekannter Anlagentyp, die Nachricht wurde NICHT ausgewertet sondern wird in ursprünglicher Form ausgegeben!");
                            break;
                    }
                }
            }
            else
            {
                // Code für den Fall, dass keine Suchbegriffe gefunden wurden
            }

            return uebergabe;

        }
    }
}
