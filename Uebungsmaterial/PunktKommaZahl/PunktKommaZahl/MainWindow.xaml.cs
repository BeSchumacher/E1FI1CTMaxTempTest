using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace PunktKommaZahl
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

        private void btnKonvZuZahl_Click(object sender, RoutedEventArgs e)
        {
            ///
			///In D-Land: 1.500,99
            ///In USA: 1,500.99
            ///
            //20.4
            string eingabe = txtEingabe.Text;
            //Variante 1
            eingabe = eingabe.Replace('.', ',');

            //Variante 2, Landesformat des Betriebssystem verwenden.
            double zahl2 = Double.Parse(eingabe, CultureInfo.CurrentCulture);
            
            //Ausgabe im Landesformat
            string zahl2AlsString = Convert.ToString(zahl2, CultureInfo.CurrentCulture); 
                
            //Variante 3
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            double temp = Convert.ToDouble(eingabe, provider);

            //Ohne Landesformat
            double zahl = Convert.ToDouble(eingabe, CultureInfo.InvariantCulture);

            //Was passiert hier, wenn du auf der Oberfläche 20.4 eingibst?
            double falsch = Convert.ToDouble(txtEingabe.Text);

        }
    }
}
