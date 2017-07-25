using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektniZadatak
{
    /// <summary>
    /// Interaction logic for WAdminMeni.xaml
    /// </summary>
    public partial class WAdminMeni : Window
    {
        public WAdminMeni()
        {
            InitializeComponent();
        }

        private void bSkola_Click(object sender, RoutedEventArgs e)
        {
            WSkola s=new WSkola();
            s.Show();
        }

        private void bNastavnici_Click(object sender, RoutedEventArgs e)
        {
            WNastavnici n =new WNastavnici();
            n.Show();
        }

        private void bKorisnici_Click(object sender, RoutedEventArgs e)
        {
            WKorisnici korisnici = new WKorisnici();
            korisnici.Show();
        }

        private void bUcenici_Click(object sender, RoutedEventArgs e)
        {
            WUcenici ucenici = new WUcenici();
            ucenici.Show();
        }

        private void bKursevi_Click(object sender, RoutedEventArgs e)
        {
            WKursevi kursevi = new WKursevi();
            kursevi.Show();
        }

        private void bUplate_Click(object sender, RoutedEventArgs e)
        {
            WUplate uplate = new WUplate();
            uplate.Show();
        }
    }
}
