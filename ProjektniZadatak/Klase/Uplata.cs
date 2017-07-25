using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekat
{
    class Uplata
    {
        public float uplata { get; set; }
        public Ucenik ucenik { get; set; }
        public Kurs kurs { get; set; }
        public String valuta { get; set; }

        public Uplata(float uplata, Ucenik ucenik, Kurs kurs, String valuta)
        {
            this.uplata = uplata;
            this.ucenik = ucenik;
            this.kurs = kurs;
            this.valuta = valuta;
        }
    }
}
