using System;

namespace Zadaca_03.Modeli
{
    public class ZdravstveniPodaci
    {
        public int IDPodataka { get; set; }
        public string OpisSimptoma { get; set; }
        public string RezultatiKrvnePretrage { get; set; }
        public string InformacijeOAlergiji { get; set; }
        public string PopisPrepisanihLijekova { get; set; }
        public string NapomeneLijecnika { get; set; }
        public string Dijagnoza { get; set; }
        public string PlanLijecenja { get; set; }
        public string OsobneBiljeske { get; set; }
        public DateTime? Termin { get; set; }
    }
}
