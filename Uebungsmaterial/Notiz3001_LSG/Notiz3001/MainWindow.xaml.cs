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

namespace Notiz3001
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtNotizen.Text = "hallo";
            //Daten einlesen per Filestream
            //"Buch öffnen."
            FileStream fs = new FileStream(@"C:\tmp\notizen.txt", FileMode.Open);
            //"Lesegerät" "Brille aufsetzten und auf Buch setzen."
            StreamReader sr = new StreamReader(fs);
            txtNotizen.Text = sr.ReadToEnd();
            //Ganz wichtig! Resourcen freigeben.
            sr.Close();
            fs.Close();

        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\tmp\notizen.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(txtNotizen.Text);
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }



        }
    }
}
