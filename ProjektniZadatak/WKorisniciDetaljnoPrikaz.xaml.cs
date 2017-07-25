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
    /// Interaction logic for WKorisniciDetaljnoPrikaz.xaml
    /// </summary>
    public partial class WKorisniciDetaljnoPrikaz : Window
    {
        public WKorisniciDetaljnoPrikaz(Korisnik k)
        {
            InitializeComponent();

            Binding b1 = new Binding();
            b1.Path = new PropertyPath("ime");
            tbIme.SetBinding(TextBox.TextProperty, b1);
            tbIme.DataContext = k;

            Binding b2 = new Binding();
            b2.Path = new PropertyPath("prezime");
            tbPrezime.SetBinding(TextBox.TextProperty, b2);
            tbPrezime.DataContext = k;

            Binding b3 = new Binding();
            b3.Path = new PropertyPath("korIme");
            tbUser.SetBinding(TextBox.TextProperty, b3);
            tbUser.DataContext = k;

            Binding b4 = new Binding();
            b4.Path = new PropertyPath("sifra");
            tbPass.SetBinding(TextBox.TextProperty, b4);
            tbPass.DataContext = k;


            Binding b5 = new Binding();
            b5.Path = new PropertyPath("tipKorisnika");
            tbTipKor.SetBinding(TextBox.TextProperty, b5);
            tbTipKor.DataContext = k;
        }

        private void bPrekid_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
