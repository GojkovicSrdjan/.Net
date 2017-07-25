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
    /// Interaction logic for WSkolaDetaljno.xaml
    /// </summary>
    public partial class WSkolaDetaljno : Window
    {
        public WSkolaDetaljno(Skola s)
        {
            InitializeComponent();


            Binding b1 = new Binding();
            b1.Path = new PropertyPath("naziv");
            tbNaziv.SetBinding(TextBox.TextProperty, b1);
            tbNaziv.DataContext = s;

            Binding b2 = new Binding();
            b2.Path = new PropertyPath("adresa");
            tbAdresa.SetBinding(TextBox.TextProperty, b2);
            tbAdresa.DataContext = s;


            Binding b3 = new Binding();
            b3.Path = new PropertyPath("brojTelefona");
            tbBrTel.SetBinding(TextBox.TextProperty, b3);
            tbBrTel.DataContext = s;


            Binding b4 = new Binding();
            b4.Path = new PropertyPath("email");
            tbMail.SetBinding(TextBox.TextProperty, b4);
            tbMail.DataContext = s;


            Binding b5 = new Binding();
            b5.Path = new PropertyPath("adresaSajta");
            tbVebSajt.SetBinding(TextBox.TextProperty, b5);
            tbVebSajt.DataContext = s;


            Binding b6 = new Binding();
            b6.Path = new PropertyPath("pib");
            tbPib.SetBinding(TextBox.TextProperty, b6);
            tbPib.DataContext = s;


            Binding b7 = new Binding();
            b7.Path = new PropertyPath("maticniBr");
            tbMaticniBr.SetBinding(TextBox.TextProperty, b7);
            tbMaticniBr.DataContext = s;

            Binding b8 = new Binding();
            b8.Path = new PropertyPath("brZiroRacuna");
            tbBrZiroRacuna.SetBinding(TextBox.TextProperty, b8);
            tbBrZiroRacuna.DataContext = s;


        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void bPrekini_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
