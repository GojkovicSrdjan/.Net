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
    /// Interaction logic for WKursevi.xaml
    /// </summary>
    public partial class WKursevi : Window
    {
        public WKursevi()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            kolone();

            
            
        }

        private void bPrikazIzmena_Click(object sender, RoutedEventArgs e)
        {
            Kurs old = ((Kurs)dgKursevi.SelectedItem).Clone();
            WKurseviDetaljno k = new WKurseviDetaljno((Kurs)dgKursevi.SelectedItem);

            bool? rez = k.ShowDialog();

            if (rez == false)
            {

                int index = Podaci.Kursevi.IndexOf((Kurs)dgKursevi.SelectedItem);
                Podaci.Kursevi[index] = old;
            }

            else
            {
                Podaci.IzmeniKurs((Kurs)dgKursevi.SelectedItem);

            }
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Kurs k = new Kurs();
            WKurseviDetaljno wk = new WKurseviDetaljno(k);
            if (wk.ShowDialog() == true)
            {

                Podaci.Kursevi.Add(k);
                Podaci.DodajKrus(k);

                
            }
        }

        private void bIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            Podaci.ObrisiKurs((Kurs)dgKursevi.SelectedItem);
            Podaci.Kursevi.Remove((Kurs)dgKursevi.SelectedItem);
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            String tekstPretrage= tbPretraga.Text;
            List<Kurs> Pretraga=new List<Kurs>();
            if (rbJezik.IsChecked == true)
            {
                foreach (Kurs k in Podaci.Kursevi)
                {
                    if (k.jezik.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(k);
                        
                    }
                }
                dgKursevi.ItemsSource = Pretraga;
                
            }
            else if (rbNivo.IsChecked==true)
            {

                foreach (Kurs k in Podaci.Kursevi)
                {
                    if (k.nivoJezika.ToLower() == tekstPretrage.ToLower())
                    {
                        Pretraga.Add(k);

                    }
                }
                dgKursevi.ItemsSource = Pretraga;
            }
            
            
            
        }

        private void bPrikaziSve_Click(object sender, RoutedEventArgs e)
        {
            dgKursevi.ItemsSource = Podaci.Kursevi;
        }

        public void kolone()
        {
            dgKursevi.AutoGenerateColumns = false;
            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = Podaci.Kursevi;
            dgKursevi.ItemsSource = cvs.View;
            dgKursevi.IsSynchronizedWithCurrentItem = true;

            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Naziv";
            c1.Binding = new Binding("naziv");
            dgKursevi.Columns.Add(c1);

            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Jezik";
            c2.Binding = new Binding("jezik");
            dgKursevi.Columns.Add(c2);

            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Nivo Jezika";
            c3.Binding = new Binding("nivoJezika");
            dgKursevi.Columns.Add(c3);

            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Cena Kursa";
            c4.Binding = new Binding("cena");
            dgKursevi.Columns.Add(c4);

            

        }
        
    }
}
