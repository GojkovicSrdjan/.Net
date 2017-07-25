using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    class Kurs
    {
        public String jezik { get; set; }
        public String nivoJezika { get; set; }
        public float cena { get; set; }
        public List<Ucenik> ucenici { get; set; }
        public Nastavnik nastavnik { get; set; }


        public Kurs(String jezik, String nivoJezika, float cena, List<Ucenik> ucenik,Nastavnik nastavnik)
        {
            this.jezik = jezik;
            this.nivoJezika = nivoJezika;
            this.cena = cena;
            this.ucenici = ucenici;
            this.nastavnik = nastavnik;
        }
    }
}
