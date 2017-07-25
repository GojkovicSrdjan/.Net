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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektniZadatak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Korisnik kor { get; set; }
        public Korisnik k;
        public MainWindow()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            


        }

        private void bOk_Click(object sender, RoutedEventArgs e)
        {
            if (Login(tbUser.Text,pbPass.Password)){
                
                   
                    if (Admin())
                    {
                        WAdminMeni a = new WAdminMeni();
                        a.ShowDialog();
                        


                    }

                    else if (Zaposleni())
                    {
                        WZapMeni z = new WZapMeni();
                        z.ShowDialog();
                        
                    }
                
            }

            else
            {
                MessageBox.Show("Neispravno korisnicko ime ili lozinka!");
            }
        }
        public static bool Login(String KorIme, String Sifra)
        {

            foreach (Korisnik k in Podaci.Korisnici)
            {

                if (KorIme.ToLower() == k.korIme.ToLower() && Sifra.ToLower() == k.sifra.ToLower())
                {

                    kor = k;
                    return true;

                }
                
            }
            
            return false;
        }

        public static bool Zaposleni()
        {
            if (kor != null)
            
                if (kor.tipKorisnika == "Zaposleni")
                    return true;
                return false;

            
        }

        public static bool Admin()
        {
            if (kor != null)

                if (kor.tipKorisnika == "Administrator")
                    return true;
            return false;


        }
    }

         
}
