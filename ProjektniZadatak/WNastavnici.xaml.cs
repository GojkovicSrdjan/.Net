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
    /// Interaction logic for WNastavnici.xaml
    /// </summary>
    public partial class WNastavnici : Window
    {
        public WNastavnici()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            kolone();
            
         
            
        

            
            
        }

        private void bPrikazIzmena_Click(object sender, RoutedEventArgs e)
        {
            Nastavnik old=((Nastavnik)dgNastavnici.SelectedItem).Clone();
            WNastavniciDetaljno wn = new WNastavniciDetaljno((Nastavnik)dgNastavnici.SelectedItem);

            bool? rez = wn.ShowDialog();

            if (rez == false)
            {

                int index = Podaci.Nastavnici.IndexOf((Nastavnik)dgNastavnici.SelectedItem);
                Podaci.Nastavnici[index] = old;
            }

            else
            {
                Podaci.IzmeniNastavnika((Nastavnik)dgNastavnici.SelectedItem);
            }
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Nastavnik n = new Nastavnik();
            WNastavniciDetaljno wn = new WNastavniciDetaljno(n);

            if (wn.ShowDialog() == true)
            {
                Podaci.Nastavnici.Add(n);
                Podaci.DodajNastavnika(n);
                
            }
        }

        private void bIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            Podaci.ObrisiNastavnika((Nastavnik)dgNastavnici.SelectedItem);
            Podaci.Nastavnici.Remove((Nastavnik)dgNastavnici.SelectedItem);

        }

        private void bPretrazi_Click(object sender, RoutedEventArgs e)
        {
            String tekstPretrage = tbPretraga.Text;
            List<Nastavnik> Pretraga = new List<Nastavnik>();
            if (rbIme.IsChecked==true)
            {
                foreach (Nastavnik n in Podaci.Nastavnici)
                {
                    if (n.ime.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(n);

                    }
                }
                dgNastavnici.ItemsSource = Pretraga;

            }
            else if (rbPrezime.IsChecked==true)
            {
                foreach (Nastavnik n in Podaci.Nastavnici)
                {
                    if (n.prezime.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(n);

                    }
                }
                dgNastavnici.ItemsSource = Pretraga;

            }
            else if (rbJMBG.IsChecked==true)
            {
                foreach (Nastavnik n in Podaci.Nastavnici)
                {
                    if (n.jmbg.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(n);

                    }
                }
                dgNastavnici.ItemsSource = Pretraga;

            }
           
        }

        public void kolone(){


            dgNastavnici.AutoGenerateColumns = false;


            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = Podaci.Nastavnici;
            dgNastavnici.ItemsSource = cvs.View;
            dgNastavnici.IsSynchronizedWithCurrentItem = true;

            

            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Ime";
            c2.Binding = new Binding("ime");
            dgNastavnici.Columns.Add(c2);

            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Prezime";
            c3.Binding = new Binding("prezime");
            dgNastavnici.Columns.Add(c3);

            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Br Telefona";
            c4.Binding = new Binding("brTelefona");
            dgNastavnici.Columns.Add(c4);

            DataGridTextColumn c5 = new DataGridTextColumn();
            c5.Header = "JMBG";
            c5.Binding = new Binding("jmbg");
            dgNastavnici.Columns.Add(c5);

            DataGridTextColumn c6 = new DataGridTextColumn();
            c6.Header = "Adresa";
            c6.Binding = new Binding("adresa");
            dgNastavnici.Columns.Add(c6);

 
        }

        private void bPrikaziSve_Click(object sender, RoutedEventArgs e)
        {
            dgNastavnici.ItemsSource = Podaci.Nastavnici;
        }

        
    }
}
