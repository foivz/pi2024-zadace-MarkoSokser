using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_03.PI2324_msokser22_DBDataSet2TableAdapters;

namespace Zadaca_03.Repozitori
{
    public class ManipulacijaPodatakaModel
    {
        private Zdravstveni_podaciTableAdapter zdravstveniPodaciTableAdapter;
        private PI2324_msokser22_DBDataSet2.Zdravstveni_podaciDataTable zdravstveniPodaciDataTable;

        public ManipulacijaPodatakaModel()
        {
            zdravstveniPodaciTableAdapter = new Zdravstveni_podaciTableAdapter();
            zdravstveniPodaciDataTable = new PI2324_msokser22_DBDataSet2.Zdravstveni_podaciDataTable();
            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            try
            {
                zdravstveniPodaciTableAdapter.Fill(zdravstveniPodaciDataTable);
            }
            catch (Exception ex)
            {
                // Obrada greške (npr. prikaz poruke korisniku)
                throw new Exception("Greška prilikom učitavanja podataka.", ex);
            }
        }

        public DataTable DohvatiPodatke()
        {
            return zdravstveniPodaciDataTable;
        }

        public void PohraniPromjene()
        {
            try
            {
                zdravstveniPodaciTableAdapter.Update(zdravstveniPodaciDataTable);
            }
            catch (Exception ex)
            {
                // Obrada greške (npr. prikaz poruke korisniku)
                throw new Exception("Greška prilikom pohranjivanja podataka.", ex);
            }
        }
    }
}