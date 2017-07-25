using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    class Korisnik
    {
        public String ime { get; set; }
        public String prezime { get; set; }
        public String korIme { get; set; }
        public String sifra { get; set; }
        public String tipKorisnika { get; set; }

        public Korisnik(String ime, String prezime, String korIme, String sifra, String tipKorisnika)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.korIme = korIme;
            this.sifra = sifra;
            this.tipKorisnika = tipKorisnika;
        }
    }
}
