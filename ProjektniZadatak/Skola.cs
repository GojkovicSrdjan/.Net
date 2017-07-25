using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektniZadatak
{
    public class Skola
    {
        public int id { get; set; }
        public String naziv { get; set; }
        public String adresa { get; set; }
        public String brojTelefona { get; set; }
        public String email { get; set; }
        public String adresaSajta { get; set; }
        public String pib { get; set; }
        public String maticniBr { get; set; }
        public String brZiroRacuna { get; set; }


        public Skola Clone()
        {
            Skola s = new Skola();
            s.naziv = this.naziv;
            s.adresa = this.adresa;
            s.brojTelefona = this.brojTelefona;
            s.email = this.email;
            s.adresaSajta = this.adresaSajta;
            s.pib = this.pib;
            s.maticniBr = this.maticniBr;
            s.brZiroRacuna = this.brZiroRacuna;
            return s;
        }
    }
}
