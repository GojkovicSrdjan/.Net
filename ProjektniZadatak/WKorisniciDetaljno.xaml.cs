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
    /// Interaction logic for WKorisniciDetaljno.xaml
    /// </summary>
    public partial class WKorisniciDetaljno : Window
    {
        public Korisnik k;
        public WKorisniciDetaljno(Korisnik k)
        {
            InitializeComponent();
            this.k = k;

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

            List<String> lista = new List<string>();
            lista.Add("Administrator");
            lista.Add("Zaposleni");


            //cbTipKorisnika.DisplayMemberPath = ("tipKorisnika");
            cbTipKorisnika.ItemsSource = lista;

            
            Binding b5 = new Binding();
            b5.Path = new PropertyPath("tipKorisnika");
            cbTipKorisnika.SetBinding(ComboBox.SelectedItemProperty, b5);
            cbTipKorisnika.DataContext = k;
            

        }

        private void bPrekini_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {


            if (tbNPass.Text != tbPPass.Text)
            {
                MessageBox.Show("Neispravna lozinka");
                return;
            }
            k.sifra = tbPPass.Text;
            
            
            this.DialogResult = true;
            this.Close();
        }
    }
}
