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
    /// Interaction logic for WNastavniciDetaljno.xaml
    /// </summary>
    public partial class WNastavniciDetaljno : Window
    {
        public WNastavniciDetaljno(Nastavnik n)
        {
            InitializeComponent();

            List<Kurs> NastavnikoviKursevi = new List<Kurs>();
            foreach (Kurs k in Podaci.Kursevi)
            {
                if (k.nastavnik==n)
                {
                    NastavnikoviKursevi.Add(k);
                }
            }

            

            Binding b2 = new Binding();
            b2.Path = new PropertyPath("ime");
            tbIme.SetBinding(TextBox.TextProperty, b2);
            tbIme.DataContext = n;


            Binding b3 = new Binding();
            b3.Path = new PropertyPath("prezime");
            tbPrezime.SetBinding(TextBox.TextProperty, b3);
            tbPrezime.DataContext = n;


            Binding b4 = new Binding();
            b4.Path = new PropertyPath("brTelefona");
            tbBrTel.SetBinding(TextBox.TextProperty, b4);
            tbBrTel.DataContext = n;


            Binding b5 = new Binding();
            b5.Path = new PropertyPath("jmbg");
            tbJmbg.SetBinding(TextBox.TextProperty, b5);
            tbJmbg.DataContext = n;


            Binding b6 = new Binding();
            b6.Path = new PropertyPath("adresa");
            tbAdresa.SetBinding(TextBox.TextProperty, b6);
            tbAdresa.DataContext = n;

            lvKursevi.DisplayMemberPath = "naziv";
            lvKursevi.ItemsSource = NastavnikoviKursevi;

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
    }
}
