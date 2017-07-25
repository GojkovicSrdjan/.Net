using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektniZadatak
{
    public class Korisnik
    {
        public int id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String korIme { get; set; }
        public String sifra { get; set; }
        public String tipKorisnika { get; set; }

        public Korisnik Clone()
        {
            Korisnik k = new Korisnik();
            k.ime = this.ime;
            k.prezime = this.prezime;
            k.korIme = this.korIme;
            k.sifra = this.sifra;
            k.tipKorisnika = this.tipKorisnika;
            return k;
        }

        
        



    }
}
