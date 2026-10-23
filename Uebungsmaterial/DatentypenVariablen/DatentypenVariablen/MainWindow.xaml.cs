using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatentypenVariablen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnBerechneAddieren_Click(object sender, RoutedEventArgs e)
        {
            //Diverse Variablen deklarieren und mit 0 initialisieren (vorbelegen), um darin Werte zu speichern.
            //Diese können dann innerhalb dieses EventHandlers btnBerechneAddieren_Click verwendet werden.
            //Die Oberfläche fordert auf, zwei GANZZAHLEN einzugeben. Dies sind Zahlen, die keine Kommastellen haben.
            //Um diese Zahlen zu speichern und mit ihnen rechnen zu können, legen wir uns folgende Variablen an: 
            int zahl1AlsGanzZahl = 0;
            int zahl2AlsGanzZahl = 0;
            int ergebnisAlsGanzzahl = 0;
            //int ist der benötigte "Datentyp". Er steht für das Wort "Integer", was auf Deutsch "Ganzzahl" heißt.
            
            //Wenn wir auf der Oberfläche nun eine Zahl in das Textfeld schreiben, weiß der Computer nicht, 
            //dass wir tatsächlich eine Zahl (im mathematischen Sinne) verwenden wollen. Für den Computer 
            //ist alles, was man in ein Textfeld einträgt ein String, also eine Reihe von Buchstaben, wobei
            //Ziffern auch als Buchstaben verwendet werden. Schreiben wir die Zahl 50 in das Textfeld, so ist das
            //für den Computer lediglich das Wort "50" bzw. ein Wort, das aus den Buchstaben '5' und '0' 
            //besteht.

            //Möchten wir die Zahlen von der Oberfläche verwenden, so müssen wir uns zunächst Variablen
            //vom Datentyp "string" anlegen. "string" steht für "Zeichenkette". Die folgenden Zeilen machen
            //dies. Zusätzlich werden die Variablen mit einem Anfangswert initialisiert. (string.Empty oder
            // einfach nur "" (Leerstring).
            string zahl1AlsString = string.Empty;
            string zahl2AlsString = ""; //Ist das Gleiche wie string.Empty. Auch möglich, old style.
            string ergebnisAlsZeichenkette = string.Empty;

            //Zahlen von Oberfläche einlesen. Von der Oberfläche kommen immer Zeichenketten (Strings), auch wenn
            //es Zahlen sind.
            zahl1AlsString = txtZahl1.Text;
            zahl2AlsString = txtZahl2.Text;

            //Damit der Computer mit den Zahlen rechnen kann, müssen diese in Zahlen konvertiert werden.
            //Hierbei müssen wir zwischen Kommazahlen und Ganzzahlen unterscheiden, da die Speicherverwaltung und 
            //die Rechenmethoden technisch grundverschieden sind.
            //Convert.To...() führt diverse Konvertierung durch:
            zahl1AlsGanzZahl = Convert.ToInt32(zahl1AlsString);
            zahl2AlsGanzZahl = Convert.ToInt32(zahl2AlsString);

            //jetzt kann gerechnet (addiert) werden:
            ergebnisAlsGanzzahl = zahl1AlsGanzZahl + zahl2AlsGanzZahl;

            //Das Ergebnis muss wieder in einen String zurückgewandelt werden, damit es auf der Oberfläche 
            //angezeigt werden kann (string = Zeichenkette):
            ergebnisAlsZeichenkette = Convert.ToString(ergebnisAlsGanzzahl);
            //Nun auf der Oberfläche in das Ausgabe-Label (lblAusgabe) schreiben.
            lblAusgabe.Content = ergebnisAlsZeichenkette;
        }

        private void btnBerechneDivision_Click(object sender, RoutedEventArgs e)
        {
            //Diverse Variablen deklarieren und mit 0 initialisieren (vorbelegen), um darin Werte zu speichern.
            //Diese können dann innerhalb dieses EventHandlers btnBerechneAddieren_Click verwendet werden.
            int zahl1AlsGanzZahl = 0;
            int zahl2AlsGanzZahl = 0;
            double ergebnisAlsKommaZahl = 0;
            string zahl1AlsString = string.Empty;
            string zahl2AlsString = ""; //Ist das Gleiche wie string.Empty. Auch möglich, old style.
            string ergebnisAlsZeichenkette = string.Empty;


            //Zahlen von Oberfläche einlesen. Von der Oberfläche kommen immer Zeichenketten (Strings), auch wenn
            //es Zahlen sind.
            zahl1AlsString = txtZahl1.Text;
            zahl2AlsString = txtZahl2.Text;

            //Damit der Computer mit den Zahlen rechnen kann, müssen diese in Zahlen konvertiert werden.
            //Hierbei müssen wir zwischen Kommazahlen und Ganzzahlen unterscheiden, da die Speicherverwaltung und 
            //die Rechenmethoden technisch grundverschieden sind.
            //Convert.To...() führt diverse Konvertierung durch:
            zahl1AlsGanzZahl = Convert.ToInt32(zahl1AlsString);
            zahl2AlsGanzZahl = Convert.ToInt32(zahl2AlsString);

            //jetzt kann gerechnet (addiert) werden.
            //Bei der Division (teilen) kann aber eine Kommazahl herauskommen. Z. B. 5:2 = 2.5
            //Deshalb müssen wir eine Kommazahl verwenden, um das Ergebnis abzuspeichern.
            ergebnisAlsKommaZahl = zahl1AlsGanzZahl / zahl2AlsGanzZahl;

            //Das Ergebnis muss wieder in einen String zurückgewandelt werden, damit es auf der Oberfläche 
            //angezeigt werden kann (string = Zeichenkette):
            ergebnisAlsZeichenkette = Convert.ToString(ergebnisAlsKommaZahl);
            //Nun auf der Oberfläche in das Ausgabe-Label (lblAusgabe) schreiben.
            lblAusgabe.Content = ergebnisAlsZeichenkette;
        }

        private void btnBerechneDivisionProof_Click(object sender, RoutedEventArgs e)
        {
            //Diverse Variablen deklarieren und mit 0 initialisieren (vorbelegen), um darin Werte zu speichern.
            //Diese können dann innerhalb dieses EventHandlers btnBerechneAddieren_Click verwendet werden.
            int zahl1AlsGanzZahl = 0;
            int zahl2AlsGanzZahl = 0;
            double ergebnisAlsKommaZahl = 0;
            string zahl1AlsString = string.Empty;
            string zahl2AlsString = ""; //Ist das Gleiche wie string.Empty. Auch möglich, old style.
            string ergebnisAlsZeichenkette = string.Empty;
            bool calcAllowed = false;


            //Zahlen von Oberfläche einlesen. Von der Oberfläche kommen immer Zeichenketten (Strings), auch wenn
            //es Zahlen sind.
            zahl1AlsString = txtZahl1.Text;
            zahl2AlsString = txtZahl2.Text;

            //Damit der Computer mit den Zahlen rechnen kann, müssen diese in Zahlen konvertiert werden.
            //Hierbei müssen wir zwischen Kommazahlen und Ganzzahlen unterscheiden, da die Speicherverwaltung und 
            //die Rechenmethoden technisch grundverschieden sind.
            //Convert.To...() führt diverse Konvertierung durch:
            zahl1AlsGanzZahl = Convert.ToInt32(zahl1AlsString);
            zahl2AlsGanzZahl = Convert.ToInt32(zahl2AlsString);

            //jetzt kann gerechnet (addiert) werden.
            //Bei der Division (teilen) kann aber eine Kommazahl herauskommen. Z. B. 5:2 = 2.5
            //Deshalb müssen wir eine Kommazahl verwenden, um das Ergebnis abzuspeichern.
            //Aber zuerst müssen wir überprüfen, ob der Nenner größer als 0 ist, da sonst
            //das Ergebnis gegen Unendlich geht. (Das geht natürlich einfacher...)
            if(zahl2AlsGanzZahl > 0)
            {
                calcAllowed = true;
            }
            else
            {
                calcAllowed = false;
            }

            //Berechnung durchführen, wenn möglich. Ansonsten Fehlermeldung ausgeben.
            if (calcAllowed == true)
            {
                ergebnisAlsKommaZahl = zahl1AlsGanzZahl / zahl2AlsGanzZahl;
                //Das Ergebnis muss wieder in einen String zurückgewandelt werden, damit es auf der Oberfläche 
                //angezeigt werden kann (string = Zeichenkette):
                ergebnisAlsZeichenkette = Convert.ToString(ergebnisAlsKommaZahl);
                //Nun auf der Oberfläche in das Ausgabe-Label (lblAusgabe) schreiben.
                lblAusgabe.Content = ergebnisAlsZeichenkette;
            }
            else
            {
                lblAusgabe.Content = "Der Nenner ist 0! Berechnung nicht möglich.";
            }

            
        }
    }
}
