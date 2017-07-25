using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektniZadatak
{
    public class Ucenik
    {
        public int id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String brTelefona { get; set; }
        public String jmbg { get; set; }
        public String adresa { get; set; }
        public List<Kurs> kursevi { get; set; }

        public String ImePrezime
        {
            get
            {
                return ime + " " + prezime;
            }
        }

        public Ucenik()
        {
            kursevi = new List<Kurs>();
        }

        public Ucenik Clone()
        {
            Ucenik u = new Ucenik();

            u.id=this.id;
            u.ime=this.ime;
            u.prezime=this.prezime;
            u.brTelefona=this.brTelefona;
            u.jmbg=this.jmbg;
            u.adresa=this.adresa;
            u.kursevi = this.kursevi;
            return u;
        }
       
        
        
    }


}
