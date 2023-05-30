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
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WhatsAppReport
{
    public class IOS
    {
        public static void ExtractMessage(string fullChat)
        {
            string fullMessage;

            MatchCollection matches;

            // Das Muster "01.01.22, 12:00 - " kennzeichnet den Beginn einer neuen Nachricht
            //ORIGINAL string pattern = @"\d\d\.\d\d\.\d\d, \d\d:\d\d - ";
            string pattern = @"\[\d\d\.\d\d\.\d\d, \d\d:\d\d:\d\d\] ";


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
            string pattern = @"\[(\d{2}\.\d{2}\.\d{2}, \d{2}:\d{2}:\d{2})\] ([^:]+): (.*)";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string timestamp = match.Groups[1].Value;
                string absender = match.Groups[2].Value.Trim();
                string nachricht = match.Groups[3].Value.Trim();

                string myTimestamp = "<br><br><b>" + timestamp + " ";
                string mySender = absender + "</b><br>";
                string myMessage = nachricht;

                Global.WriteToKommunikationsprotokoll(myTimestamp, mySender, FormatiereNachrichteninhalt(myMessage));
            }
            else
            {
                string myTimestamp = "Fehler: Nachricht konnte nicht ausgewertet werden";
                string mySender = "";
                string myMessage = "";

                Global.WriteToKommunikationsprotokoll(myTimestamp, mySender, FormatiereNachrichteninhalt(myMessage));
            }
        }

        public static string FormatiereNachrichteninhalt(string Nachrichteninhalt)
        {
            // Vordefinierte Suchbegriffe
            string[] keywords = { "Du hast diese Nachricht gelöscht.", "<Anhang: ", "http" };

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
                    return Nachrichteninhalt;
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
                            return Nachrichteninhalt.Replace(url, link);

                        case "Du hast diese Nachricht gelöscht.":  // Gelöschte Datei in Nachricht
                            Global.AnzahlGeloeschteDateien++;
                            return Nachrichteninhalt.Replace("Du hast diese Nachricht gelöscht.", "*** Nachricht oder Datei nicht mehr verfügbar ***");

                        case "<Anhang: ":  // Datei in Nachricht; Nachrichteninhalt kann nur den Dateinamen enthalten oder einen Dateinamen im Text

                            string pattern = @"<Anhang: ([^>]+)>";
                            Match match = Regex.Match(Nachrichteninhalt, pattern);
                            string anhang = match.Groups[1].Value;

                            if (match.Success)
                            {
                                string temp = "<Anhang: " + anhang + ">";
                                return Nachrichteninhalt.Replace(temp, Global.DateiEinbindung(anhang));
                            }
                            else
                            {
                                return Nachrichteninhalt;
                            }

                        default:
                            // Bislang nicht bekannte Anlage in einer Nachricht gefunden, dieser Fall kann derzeit nicht verarbeitet werden! Es wird nur die Originalnachricht ausgegeben
                            MessageBox.Show("In einer Nachricht befand sich ein bislang unbekannter Anlagentyp, die Nachricht wurde NICHT ausgewertet sondern wird in ursprünglicher Form ausgegeben!");
                            return Nachrichteninhalt;
                    }
                }
            }
            else
            {
                // Code für den Fall, dass keine Suchbegriffe gefunden wurden
                return Nachrichteninhalt;
            }
        }

    }
}
