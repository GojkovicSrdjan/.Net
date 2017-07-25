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
    /// Interaction logic for WUplate.xaml
    /// </summary>
    public partial class WUplate : Window
    {
        public WUplate()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            kolone();
            
            
            
        }

        private void bIzmena_Click(object sender, RoutedEventArgs e)
        {
            Uplata old = ((Uplata)dgUplate.SelectedItem).Clone();
            WUplateDetaljno u = new WUplateDetaljno((Uplata)dgUplate.SelectedItem);

            bool? rez = u.ShowDialog();

            if (rez == false)
            {
                int index = Podaci.Uplate.IndexOf((Uplata)dgUplate.SelectedItem);
                Podaci.Uplate[index] = old;

            }

            else
            {
                Podaci.IzmeniUplatu((Uplata)dgUplate.SelectedItem);
            }
            
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Uplata u = new Uplata();
            WUplateDetaljno wu = new WUplateDetaljno(u);
            if (wu.ShowDialog() == true)
            {

                Podaci.Uplate.Add(u);
                Podaci.DodajUplatu(u);

                
            }
        }

        private void bIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            Podaci.ObrisiUplatu((Uplata)dgUplate.SelectedItem);
            Podaci.Uplate.Remove((Uplata)dgUplate.SelectedItem);
            
        }

        

        private void bPretrazi_Click(object sender, RoutedEventArgs e)
        {
            String tekstPretrage = tbPretraga.Text;
            List<Uplata> Pretraga = new List<Uplata>();
            if (rbKurs.IsChecked==true)
            {
                foreach (Uplata u in Podaci.Uplate)
                {
                    if (tekstPretrage.ToLower() == u.kurs.ToString().ToLower())
                    {
                        Pretraga.Add(u);
                    }
                }

                dgUplate.ItemsSource = Pretraga;
            }

            if (rbUcenik.IsChecked==true)
            {
                foreach (Uplata u in Podaci.Uplate)
                {
                    if (tekstPretrage.ToLower() == u.ucenik.ToString().ToLower())
                    {
                        Pretraga.Add(u);
                    }
                }

                dgUplate.ItemsSource = Pretraga;
            }
        }

        public void kolone()
        {
            dgUplate.AutoGenerateColumns = false;
            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = Podaci.Uplate;
            dgUplate.ItemsSource = cvs.View;
            dgUplate.IsSynchronizedWithCurrentItem = true;

            

            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Iznos";
            c2.Binding = new Binding("iznos");
            dgUplate.Columns.Add(c2);


            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Valuta";
            c3.Binding = new Binding("valuta");
            dgUplate.Columns.Add(c3);


            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Datum uplate";
            c4.Binding = new Binding("datum");
            dgUplate.Columns.Add(c4);

        }

        private void bPrikaziSve_Click(object sender, RoutedEventArgs e)
        {
            dgUplate.ItemsSource = Podaci.Uplate;
        }
    }
}
