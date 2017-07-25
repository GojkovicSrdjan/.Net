using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    class Ucenik
    {
        public String id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public int brTelefona { get; set; }
        public int jmbg { get; set; }
        public String adresa { get; set; }

        public Ucenik(String id, String ime, String prezime,
            int brTelefona, int jmbg, String adresa)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.brTelefona = brTelefona;
            this.jmbg = jmbg;
            this.adresa = adresa;
        }
    
    }


}
