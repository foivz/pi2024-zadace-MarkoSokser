using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_03.Modeli
{
    public class Korisnik
    {
        public int IdKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorIme { get; set; }
        public int Lozinka { get; set; }
        public int IdPodataka { get; set; }  // Foreign key reference

        // Assuming there's a navigation property for the related ZdravstveniPodaci class
        public ZdravstveniPodaci ZdravstveniPodaci { get; set; }
    }
}

