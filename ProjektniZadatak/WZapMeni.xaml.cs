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
    /// Interaction logic for WZapMeni.xaml
    /// </summary>
    public partial class WZapMeni : Window
    {
        public WZapMeni()
        {
            InitializeComponent();
        }

        private void bUcenici_Click(object sender, RoutedEventArgs e)
        {
            WUcenici ucenici = new WUcenici();
            ucenici.Show();
        }

        private void bKursevi_Click(object sender, RoutedEventArgs e)
        {
            WKursevi k = new WKursevi();
            k.Show();
        }

        private void bUplate_Click(object sender, RoutedEventArgs e)
        {
            WUplate uplate = new WUplate();
            uplate.Show();
        }
    }
}
