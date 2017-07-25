using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    class Skola
    {
        public String naziv { get; set; }
        public String adresa { get; set; }
        public int brojTelefona { get; set; }
        public String email { get; set; }
        public String adresaSajta { get; set; }
        public int pib { get; set; }
        public int maticniBr { get; set; }
        public int brZiroRacuna { get; set; }


        public Skola(String naziv, String adresa, int brojTelefona, String email, String adresaSajta,
            int pib, int maticniBr, int brZiroRacuna)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
            this.email = email;
            this.adresaSajta = adresaSajta;
            this.pib = pib;
            this.maticniBr = maticniBr;
            this.brojTelefona = brZiroRacuna;
        }
    }
}
