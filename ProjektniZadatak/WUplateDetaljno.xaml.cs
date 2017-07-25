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
    /// Interaction logic for WUplateDetaljno.xaml
    /// </summary>
    public partial class WUplateDetaljno : Window
    {
        public WUplateDetaljno(Uplata u)
        {
            InitializeComponent();

            Binding b1 = new Binding();
            b1.Path = new PropertyPath("iznos");
            tbUplata.SetBinding(TextBox.TextProperty, b1);
            tbUplata.DataContext = u;

            Binding b2 = new Binding();
            b2.Path = new PropertyPath("valuta");
            tbValuta.SetBinding(TextBox.TextProperty, b2);
            tbValuta.DataContext = u;

            cbKurs.DisplayMemberPath = "naziv";
            cbKurs.ItemsSource = Podaci.Kursevi;

            Binding b3 = new Binding();
            b3.Path = new PropertyPath("kurs");
            cbKurs.SetBinding(ComboBox.SelectedItemProperty, b3);
            cbKurs.DataContext = u;


            cbUcenik.DisplayMemberPath = "ImePrezime";
            cbUcenik.ItemsSource = Podaci.Ucenici;

            Binding b4 = new Binding();
            b4.Path = new PropertyPath("ucenik");
            cbUcenik.SetBinding(ComboBox.SelectedItemProperty, b4);
            cbUcenik.DataContext = u;

            Binding b5 = new Binding();
            b5.Path = new PropertyPath("datum");
            dpDatumUplate.SetBinding(DatePicker.SelectedDateProperty, b5);
            dpDatumUplate.DataContext = u;

            
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
