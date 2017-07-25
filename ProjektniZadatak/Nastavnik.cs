using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektniZadatak
{
    public class Nastavnik
    {
        public int id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String brTelefona { get; set; }
        public String jmbg { get; set; }
        public String adresa { get; set; }
        public List<Kurs> ListaKurseva { get; set; }

        public String ImePrezime
        {
            get
            {
                return ime + " " + prezime;
            }
        }

        public Nastavnik()
        {
            ListaKurseva = new List<Kurs>();
        }


        public Nastavnik Clone()
        {
            Nastavnik n = new Nastavnik();
            n.id = this.id;
            n.ime = this.ime;
            n.prezime = this.prezime;
            n.brTelefona = this.brTelefona;
            n.jmbg = this.jmbg;
            n.adresa = this.adresa;
            n.ListaKurseva = this.ListaKurseva;
            return n;
        }
        public override string ToString()
        {
            return ImePrezime;
        }

       
    }
}
