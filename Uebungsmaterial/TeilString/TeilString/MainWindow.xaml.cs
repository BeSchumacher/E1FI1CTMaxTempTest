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

namespace TeilString
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

        private void btnSplit_Click(object sender, RoutedEventArgs e)
        {
            string textAusTextBox = txtEingabe.Text;

            //Zeichenkette (String) zerlegen anhand des Zeichens ','.
            //Beachte das Beispiel weiter unten in DemoStringSplit()
            //Es wird ein sog. Array zurückgegeben. Beachte die []-Klammern am Datentyp!!!
            string[] stringTeile = textAusTextBox.Split(',');

            //Auf die einzelnen Elemente in stringTeile zugreifen.
            lblAusgabe.Content = stringTeile[0] + " ---" + stringTeile[1] + "---" + stringTeile[2];
        }

        private void DemoStringSplit()
        {
            //Beispiel:
            //Gegebener String: "Das;ist;ein;Teilstring."
            string vorgabe = "Das;ist;ein;Teilstring.";

            //Die Split-Methode zerteilt "vorgabe".
            //Es kommt also nicht ein einzelner String als Ergebnis heraus,
            //sondern MEHRERE String. Das nennt man Array of Strings und
            //muss so: string[] angelegt (deklariert) werden.
            string[] einzelTeile = vorgabe.Split(';');

            //Jetzt kann ich auf die einzelnen Elemente schreibend oder 
            //lesend zugreifen.
            //Hier als Beispiel die Ausgabe in einer MessageBox:
            //Es wird das Wort "ein" ausgegeben.
            MessageBox.Show(einzelTeile[2]);

            //Aufgabe: Gibt die anderen Worte in einer MsgBox aus.
            //...

            //Jetzt überschreiben wir das Wort "Das" mit dem Wert "Hallo";
            einzelTeile[0] = "Hallo";

            //Beachte immer, dass der Index bei 0 beginnt.
            //Geht natürlich auch mit int, double, bool und allen anderen Datentypen.
        }
    }
}
