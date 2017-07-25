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
    /// Interaction logic for WUceniciDetaljno.xaml
    /// </summary>
    public partial class WUceniciDetaljno : Window
    {
        public string dodatiKurs;
        public Ucenik u;
        public Uplata up;
        private Ucenik selektovaniUcenik;
        public List<Uplata> UplateSelektovanogUcenika = new List<Uplata>();
        public WUceniciDetaljno(Ucenik u)
        {
            this.u = u;
            
            InitializeComponent();

            selektovaniUcenik = u;

            foreach (Uplata uc in Podaci.Uplate)
            {
                if (uc.ucenik == u)
                {
                    UplateSelektovanogUcenika.Add(uc);

                }
            }

           List<Kurs> UcenikoviKursevi = new List<Kurs>();
            foreach (Kurs k in Podaci.Kursevi)
            {
                if (k.ucenici.Contains(u))
                {
                    UcenikoviKursevi.Add(k);
                }
            }
            
            

            

            Binding b2 = new Binding();
            b2.Path = new PropertyPath("ime");
            tbIme.SetBinding(TextBox.TextProperty, b2);
            tbIme.DataContext = u;


            Binding b3 = new Binding();
            b3.Path = new PropertyPath("prezime");
            tbPrezime.SetBinding(TextBox.TextProperty, b3);
            tbPrezime.DataContext = u;


            Binding b4 = new Binding();
            b4.Path = new PropertyPath("brTelefona");
            tbBrTel.SetBinding(TextBox.TextProperty, b4);
            tbBrTel.DataContext = u;


            Binding b5 = new Binding();
            b5.Path = new PropertyPath("jmbg");
            tbJmbg.SetBinding(TextBox.TextProperty, b5);
            tbJmbg.DataContext = u;


            Binding b6 = new Binding();
            b6.Path = new PropertyPath("adresa");
            tbAdresa.SetBinding(TextBox.TextProperty, b6);
            tbAdresa.DataContext = u;

            cbKurs.DisplayMemberPath = "naziv";
            cbKurs.ItemsSource = Podaci.Kursevi;

            Binding b7 = new Binding();
            b7.Path = new PropertyPath("kurs");
            cbKurs.SetBinding(ComboBox.SelectedItemProperty, b7);
            cbKurs.DataContext = u;

            kolone();


            Binding b8 = new Binding();
            b8.Path = new PropertyPath("kurs");
            lvKursevi.SetBinding(ListView.SelectedItemProperty, b8);
            lvKursevi.DataContext = u;

            lvKursevi.DisplayMemberPath = "naziv";
            lvKursevi.ItemsSource = UcenikoviKursevi;
            

           
            
        }

        private void bPrekini_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void bUplata_Click(object sender, RoutedEventArgs e)
        {
            Uplata nova = new Uplata();
            nova.ucenik = selektovaniUcenik;
            nova.kurs = ((Kurs)lvKursevi.SelectedItem);
            WUplateDetaljno wu=new WUplateDetaljno(nova);
            wu.ShowDialog();
        }

        public void kolone()
        {
            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = UplateSelektovanogUcenika;
            dgUplate.ItemsSource = cvs.View;
            dgUplate.IsSynchronizedWithCurrentItem = true;
            dgUplate.AutoGenerateColumns = false;
            
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Iznos";
            c1.Binding = new Binding("iznos");
            dgUplate.Columns.Add(c1);

            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Datum";
            c3.Binding = new Binding("datum");
            dgUplate.Columns.Add(c3);

            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Valuta";
            c4.Binding = new Binding("valuta");
            dgUplate.Columns.Add(c4);


        }

        private void bIzbrisiKurs_Click(object sender, RoutedEventArgs e)
        {

            u.kursevi.Remove((Kurs)lvKursevi.SelectedItem);
            lvKursevi.ItemsSource = null;
            lvKursevi.ItemsSource = u.kursevi;
            

        }

        private void bDodajKurs_Click(object sender, RoutedEventArgs e)
        {
            bool postoji = false;
            foreach (Kurs k in u.kursevi)
            {
                if (k == cbKurs.SelectedItem)
                {
                    postoji = true;
                    break;
                }
            }
            
            
            if (!postoji)
            {
                u.kursevi.Add((Kurs)cbKurs.SelectedItem);
            }
            else
            {
                MessageBox.Show("Kurs koji ste odabrali, ucenik vec pohadja!");
            }
            lvKursevi.ItemsSource = null;
            lvKursevi.ItemsSource = u.kursevi;
            
            
        }

        
    }
}
