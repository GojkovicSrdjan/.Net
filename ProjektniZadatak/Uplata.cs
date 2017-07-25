using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektniZadatak{
    public class Uplata
    {
        public int id { get; set; }
        public decimal iznos { get; set; }
        public Ucenik ucenik { get; set; }
        public Kurs kurs { get; set; }
        public DateTime datum { get; set; }
        public String valuta { get; set; }

        public Uplata Clone()
        {
            Uplata u = new Uplata();
            u.id = this.id;
            u.iznos = this.iznos;
            u.ucenik = this.ucenik;
            u.kurs = this.kurs;
            u.datum = this.datum;
            u.valuta = this.valuta;
            return u;
        }
       /* public override string ToString()
        {
            return kurs.ToString();
        }*/
    }
}
