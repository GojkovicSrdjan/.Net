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
    /// Interaction logic for WSkola.xaml
    /// </summary>
    public partial class WSkola : Window
    {
        public WSkola()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();

            dgSkola.AutoGenerateColumns = true;
            CollectionViewSource cvs = new CollectionViewSource();
            cvs.Source = Podaci.Skole;
            dgSkola.ItemsSource = cvs.View;
            dgSkola.IsSynchronizedWithCurrentItem = true;
        }

        private void bPrikazIzmena_Click(object sender, RoutedEventArgs e)
        {
            Skola old=((Skola)dgSkola.SelectedItem).Clone();
            WSkolaDetaljno ws=new WSkolaDetaljno((Skola)dgSkola.SelectedItem);

            bool? rez = ws.ShowDialog();

            if (rez == false)
            {

                int index = Podaci.Skole.IndexOf((Skola)dgSkola.SelectedItem);
                Podaci.Skole[index] = old;
            }

            else
            {
                Podaci.IzmeniSkolu((Skola)dgSkola.SelectedItem);
            }
        }
    }
}
