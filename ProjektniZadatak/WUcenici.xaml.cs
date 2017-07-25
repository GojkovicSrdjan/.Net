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
    /// Interaction logic for WUcenici.xaml
    /// </summary>
    public partial class WUcenici : Window
    {
        public WUcenici()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            kolone();

            
        }

        private void bPrikazIzmena_Click(object sender, RoutedEventArgs e)
        {
            Ucenik old = ((Ucenik)dgUcenici.SelectedItem).Clone();
            WUceniciDetaljno u = new WUceniciDetaljno((Ucenik)dgUcenici.SelectedItem);

            bool? rez = u.ShowDialog();

            if (rez == false)
            {
                int index = Podaci.Ucenici.IndexOf((Ucenik)dgUcenici.SelectedItem);
                Podaci.Ucenici[index] = old;
            }
            else
            {

                Podaci.IzmeniUcenika((Ucenik)dgUcenici.SelectedItem);
            }
           
        }

        private void bIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            Podaci.ObrisiUcenika((Ucenik)dgUcenici.SelectedItem);
            Podaci.Ucenici.Remove((Ucenik)dgUcenici.SelectedItem);
            
            
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Ucenik u = new Ucenik();
            WUceniciDetaljno wu = new WUceniciDetaljno(u);
            if (wu.ShowDialog() == true)
            {

                Podaci.Ucenici.Add(u);
                Podaci.DodajUcenika(u);

            }
        }

        private void bPretrazi_Click(object sender, RoutedEventArgs e)
        {
            String tekstPretrage = tbPretraga.Text;
            List<Ucenik> Pretraga = new List<Ucenik>();
            if (rbIme.IsChecked==true)
            {
                foreach (Ucenik u in Podaci.Ucenici)
                {
                    if (u.ime.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(u);

                    }
                }

                dgUcenici.ItemsSource = Pretraga;

            }
            if (rbPrezime.IsChecked==true)
            {
                foreach (Ucenik u in Podaci.Ucenici)
                {
                    if (u.prezime.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(u);

                    }
                }

                dgUcenici.ItemsSource = Pretraga;

            }
            if (rbJMBG.IsChecked==true)
            {
                foreach (Ucenik u in Podaci.Ucenici)
                {
                    if (u.jmbg.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(u);

                    }
                }

                dgUcenici.ItemsSource = Pretraga;

            }
            
        }

        public void kolone()
        {

            dgUcenici.AutoGenerateColumns = false;
            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = Podaci.Ucenici;
            dgUcenici.ItemsSource = cvs.View;
            dgUcenici.IsSynchronizedWithCurrentItem = true;

            
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Ime";
            c2.Binding = new Binding("ime");
            dgUcenici.Columns.Add(c2);

            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Prezime";
            c3.Binding = new Binding("prezime");
            dgUcenici.Columns.Add(c3);

            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Br Telefona";
            c4.Binding = new Binding("brTelefona");
            dgUcenici.Columns.Add(c4);

            DataGridTextColumn c5 = new DataGridTextColumn();
            c5.Header = "JMBG";
            c5.Binding = new Binding("jmbg");
            dgUcenici.Columns.Add(c5);

            DataGridTextColumn c6 = new DataGridTextColumn();
            c6.Header = "Adresa";
            c6.Binding = new Binding("adresa");
            dgUcenici.Columns.Add(c6);
            
        }

        private void bPrikaziSve_Click(object sender, RoutedEventArgs e)
        {
            dgUcenici.ItemsSource = Podaci.Ucenici;
        }
    }
}
