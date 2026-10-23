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

namespace VerzweigungIF
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

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            ///Um den zeilenweisen Ablauf eines Programms in unterschiedliche 
            ///Bahnen zu lenken, kann man die eine "If"- oder "If/else"-Verzweigung verwenden.
            ///Die Bedingung in einer IF-Verzweigung muss immer mit ja (true) oder nein (false)
            ///beantwortet werden können.
            ///Das erste Beispiel liest zwei Zahlen von der Oberfläche ein und führt folgende 
            ///Logik aus:
            ///Verbal ausgedrückt:
            ///Ist zahlA größer als zahlB?
            ///-> Wenn ja/true (also die Bedingung trifft zu), dann gebe die Meldung "A ist größer als B." aus.
            ///-> Wenn nein/false, dann tue nichts und führe die nächste Zeile (nach //Beispiel 2) aus.
            ///
            int zahlA = 0;
            int zahlB = 0;
            zahlA = Convert.ToInt32(txtEingabeA.Text);
            zahlB = Convert.ToInt32(txtEingabeB.Text);

            if(zahlA > zahlB)
            {
                lblAusgabe.Content = "A ist größer als B.";
            }

            ///Beispiel 2
            ///Hier wird überprüft, ob zahlA größerGLEICH zahlB ist.
            if(zahlA >= zahlB)
            {
                lblAusgabe.Content = "A ist größer als oder gleich groß wie B.";
            }

            ///Beispiel 3
            ///Hier wird nur eine Ausgabe erstellt, wenn die Zahlen gleich groß sind.
            ///Wichtig: Der Vergleich wird immer mit zwei "=" durchgeführt.
            if(zahlA == zahlB)
            {
                lblAusgabe.Content = "A und B sind genau gleich groß.";
            }

            ///Probiere das Programm jetzt aus.
            ///

            

        }

        private void btnGo2_Click(object sender, RoutedEventArgs e)
        {
            ///Genauso können auch logische Operatoren verwendet werden, die true oder false
            ///zurückgeben.
            ///Die folgende Abfrage überprüft, ob der Text in TextBox txtEingabeA leer ist.
            ///Hierfür wird die Methode IsNullOrEmpty verwendet. Diese gibt das Ergebnis true zurück,
            ///wenn der Test in txtEingabeA leer (oder null = nicht vorhanden) ist.
            if (string.IsNullOrEmpty(txtEingabeA.Text) == true)
            {
                lblAusgabe.Content = "Das Textfeld EingabeA ist leer.";
            }

            ///Die Logik kann auch "umgedreht" werden, in dem man statt "==" (gleich) 
            ///den Operator "!=" (ungleich) verwendet. 
            if (string.IsNullOrEmpty(txtEingabeA.Text) != false)
            {
                lblAusgabe.Content = "Das Textfeld EingabeA ist leer.";
            }

            ///Häufig werden die oberen Abfragen auch etwas vereinfacht dargestellt.
            ///if(txtEingabeA.Text == "") oder if(txtEingabeA.Text == string.Empty)
            ///Probiere es aus und ersetze die if-Bedingungen oben.

            ///Bedingungen verknüpfen
            ///Es können auch zwei (oder mehrere Bedingungen) miteinander verknüpft werden.
            ///Die folgende Überprüfung testet, ob sich in beiden TextBoxen Text befindet. 
            ///Verknüpfungsoperator: && (= UND)
            if (txtEingabeA.Text != "" && txtEingabeB.Text != "")
            {
                lblAusgabe.Content = "Gut, in beiden Textfeldern befinden sich Angaben.";
            }

            ///Wenn der Text in TextBoxA ODER in TextBoxB leer ist, dann soll eine Meldung
            ///ausgegeben werden.
            ///
            if (txtEingabeA.Text == "" || txtEingabeB.Text == "")
            {
                lblAusgabe.Content = "In einem (oder beiden) Textfeld fehlt eine Angabe.";
            }


            ///Tipp am Rande:
            ///So gibst du eine MessageBox aus:
            MessageBox.Show("Du hast das Tutorial erfolgreich durchgeführt!");
        }

        private void btnElse_Click(object sender, RoutedEventArgs e)
        {
            ///Der else-Zweig
            ///Soll explizit auch der andere Fall einer Abfrage behandelt werden,
            ///so kann das Schlüsselwort "else" verwendet werden.
            ///Die Abfrage unten vergleicht die Länge (!) des Textes in TextBox
            ///txtEingabeA mit der Zahl 5. Also: "Ist der Text in txtEingabeA kürzer
            ///als 5 Zeichen?"
            ///Ja: "Die Eingabe ist kürzer als 5 Zeichen."
            ///NEIN: "Die Eingabe mindestens 5 Zeichen lang."
            if(txtEingabeA.Text.Length < 5)
            {
                lblAusgabe.Content = "Die Eingabe ist kürzer als 5 Zeichen.";
            }
            else
            {
                lblAusgabe.Content = "Die Eingabe mindestens 5 Zeichen lang.";
            }

            ///In beiden Fällen wird die folgende MessageBox angezeigt. Also genau dann,
            ///wenn einer der beiden Fälle abgearbeitet worden ist und das Programm
            ///im "Hauptpfad" weiterläuft.
            MessageBox.Show("ELSE macht Sinn!");


        }

        private void btnElseIfElse_Click(object sender, RoutedEventArgs e)
        {
            ///IF/ELSE kann auch verschachtelt werden.
            ///
            if (txtEingabeA.Text.Length < 5)
            {
                lblAusgabe.Content = "Die Eingabe ist kürzer als 5 Zeichen.";
            }
            else if(txtEingabeA.Text.Length >= 5 && txtEingabeA.Text.Length < 10)
            {
                lblAusgabe.Content = "Die Eingabe ist zwischen 5 und 9 Zeichen lang.";
            }
            else
            {
                lblAusgabe.Content = "Die Eingabe ist länger als 9 Zeichen.";
            }

            ///Es bleibt aber immer eine if/else-Verzweigung...
            ///Für später: in if/else können Bereiche abgefragt werden.
            ///Bei switch/case nur fest (konstante) Werte.
        }
    }
}
