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
    /// Interaction logic for WKurseviDetaljno.xaml
    /// </summary>
    public partial class WKurseviDetaljno : Window
    {
        
        public WKurseviDetaljno(Kurs k)
        {
            InitializeComponent();


            Binding b1 = new Binding();
            b1.Path = new PropertyPath("jezik");
            tbJezik.SetBinding(TextBox.TextProperty, b1);
            tbJezik.DataContext = k;

            Binding b2 = new Binding();
            b2.Path = new PropertyPath("nivoJezika");
            tbNivo.SetBinding(TextBox.TextProperty, b2);
            tbNivo.DataContext = k;


            Binding b3 = new Binding();
            b3.Path = new PropertyPath("naziv");
            tbNaziv.SetBinding(TextBox.TextProperty, b3);
            tbNaziv.DataContext = k;

            cbNastavnik.DisplayMemberPath = ("ImePrezime");
            cbNastavnik.ItemsSource = Podaci.Nastavnici;

            Binding b4 = new Binding();
            b4.Path = new PropertyPath("nastavnik");
            cbNastavnik.SetBinding(ComboBox.SelectedItemProperty, b4);
            cbNastavnik.DataContext = k;


            Binding b5 = new Binding();
            b5.Path = new PropertyPath("cena");
            tbCena.SetBinding(TextBox.TextProperty, b5);
            tbCena.DataContext = k;


            lvUcenici.DisplayMemberPath = ("ImePrezime");
            lvUcenici.ItemsSource = k.ucenici;
            
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
