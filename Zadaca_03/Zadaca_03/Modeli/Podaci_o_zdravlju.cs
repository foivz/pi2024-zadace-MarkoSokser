using System;

namespace Zadaca_03.Modeli
{
    public class ZdravstveniPodaci
    {
        public int ID_podataka { get; set; }
        public string Opis_simtoma { get; set; }
        public string Rezultati_krvne_pretrage { get; set; }
        public string Informacije_o_alergiji { get; set; }
        public string Popis_prepisanih_lijekova { get; set; }
        public string Napomene_liječnika { get; set; }
        public string Dijagnoza { get; set; }
        public string Plan_liječenja { get; set; }
        public string Osobne_bilješke { get; set; }
        public DateTime? Termin { get; set; }
    }
}
