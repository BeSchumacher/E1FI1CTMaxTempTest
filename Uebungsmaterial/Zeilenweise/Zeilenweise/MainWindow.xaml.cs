using System;
using System.Collections.Generic;
using System.IO;
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

namespace Zeilenweise
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

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            int zeilenNummer = 0;
            txtAusgabe.Text = string.Empty;

            FileStream fs = new FileStream(@"temps.csv", FileMode.Open);

            StreamReader sr = new StreamReader(fs);

            while (sr.EndOfStream == false)
            {
                //Eigentlich muss zeilenNummer in einen String konvertiert werden.
                //...geht in diesem Fall auch so. -> Warum????
                txtAusgabe.Text = txtAusgabe.Text + "Zeile " + zeilenNummer + ": " + sr.ReadLine() + Environment.NewLine;
                zeilenNummer = zeilenNummer + 1; //Zeilennummer um 1 erhöhen.
            }

            //Ganz wichtig! Resourcen freigeben.
            sr.Close();
            fs.Close();
        }
    }
}
