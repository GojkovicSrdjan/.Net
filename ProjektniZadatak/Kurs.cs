using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektniZadatak
{
    public class Kurs
    {
        public int id { get; set; }
        public String naziv { get; set; }
        public String jezik { get; set; }
        public String nivoJezika { get; set; }
        public decimal cena { get; set; }
        public List<Ucenik> ucenici { get; set; }
        public Nastavnik nastavnik { get; set; }

        public Kurs()
        {
            ucenici = new List<Ucenik>();
        }

        public Kurs Clone()
        {
            Kurs k=new Kurs();
            k.naziv = this.naziv;
            k.jezik=this.jezik;
            k.nivoJezika=this.nivoJezika;
            k.cena = this.cena;
            k.ucenici=this.ucenici;
            k.nastavnik=this.nastavnik;
            return k;
        }
    }
}
