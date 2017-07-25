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
    /// Interaction logic for WKorisnici.xaml
    /// </summary>
    public partial class WKorisnici : Window
    {
        public WKorisnici()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            kolone();
           
        }

        private void bIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            Podaci.ObrisiKorisnika((Korisnik)dgKorisnici.SelectedItem);
            Podaci.Korisnici.Remove((Korisnik)dgKorisnici.SelectedItem);
            
            
        }

        private void bIzmena_Click(object sender, RoutedEventArgs e)
        {
            Korisnik old = ((Korisnik)dgKorisnici.SelectedItem).Clone();
            WKorisniciDetaljno wk = new WKorisniciDetaljno((Korisnik)dgKorisnici.SelectedItem);

            bool? rez = wk.ShowDialog();

            if (rez == false)
            {


                int index = Podaci.Korisnici.IndexOf((Korisnik)dgKorisnici.SelectedItem);
                Podaci.Korisnici[index] = old;
            }
            else
            {
                Podaci.IzmeniKorisnika((Korisnik)dgKorisnici.SelectedItem);
            }

        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Korisnik k = new Korisnik();
            WKorisniciDetaljno wk = new WKorisniciDetaljno(k);
            if (wk.ShowDialog() == true)
            {
                Podaci.Korisnici.Add(k);
                Podaci.DodajKorisnika(k);
                
            }
        }

        private void bPrikaz_Click(object sender, RoutedEventArgs e)
        {
            Korisnik old = ((Korisnik)dgKorisnici.SelectedItem).Clone();
            WKorisniciDetaljnoPrikaz wk = new WKorisniciDetaljnoPrikaz((Korisnik)dgKorisnici.SelectedItem);
            wk.ShowDialog();

            int index = Podaci.Korisnici.IndexOf((Korisnik)dgKorisnici.SelectedItem);
            Podaci.Korisnici[index] = old;

        }

        private void bPretrazi_Click(object sender, RoutedEventArgs e)
        {
            String tekstPretrage = tbPretraga.Text;
            List<Korisnik> Pretraga = new List<Korisnik>();
            if (rbIme.IsChecked==true)
            {
                foreach (Korisnik k in Podaci.Korisnici)
                {
                    if (tekstPretrage.ToLower() == k.ime.ToLower())
                    {
                        Pretraga.Add(k);

                    }
                }
                dgKorisnici.ItemsSource = Pretraga;

            }

            else if (rbPrezime.IsChecked==true)
            {
                foreach (Korisnik k in Podaci.Korisnici)
                {
                    if (tekstPretrage.ToLower() == k.prezime.ToLower())
                    {
                        Pretraga.Add(k);
                    }
                }
                dgKorisnici.ItemsSource = Pretraga;

            }

            else if (rbKorIme.IsChecked==true)
            {
                foreach (Korisnik k in Podaci.Korisnici)
                {
                    if (tekstPretrage.ToLower() == k.korIme.ToLower())
                    {
                        Pretraga.Add(k);
                    }

                }
                dgKorisnici.ItemsSource = Pretraga;

            }
           
        }

        private void bPrikaziSve_Click(object sender, RoutedEventArgs e)
        {
            dgKorisnici.ItemsSource = Podaci.Korisnici;
        }

        public void kolone()
        {


            dgKorisnici.AutoGenerateColumns = false;


            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = Podaci.Korisnici;
            dgKorisnici.ItemsSource = cvs.View;
            dgKorisnici.IsSynchronizedWithCurrentItem = true;



            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Ime";
            c2.Binding = new Binding("ime");
            dgKorisnici.Columns.Add(c2);

            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Prezime";
            c3.Binding = new Binding("prezime");
            dgKorisnici.Columns.Add(c3);


            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Korisnicko Ime";
            c4.Binding = new Binding("korIme");
            dgKorisnici.Columns.Add(c4);

            DataGridTextColumn c5 = new DataGridTextColumn();
            c5.Header = "Sifra";
            c5.Binding = new Binding("sifra");
            dgKorisnici.Columns.Add(c5);

            DataGridTextColumn c6 = new DataGridTextColumn();
            c6.Header = "Tip Korisnika";
            c6.Binding = new Binding("tipKorisnika");
            dgKorisnici.Columns.Add(c6);
        }
    }
}
