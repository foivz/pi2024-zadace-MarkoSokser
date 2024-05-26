using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Zadaca_03.Modeli;
using Zadaca_03.PI2324_msokser22_DBDataSet2TableAdapters;

namespace Zadaca_03.Repozitori
{
    public class OsobniZdravstveniPodaciModel
    {
        private Zdravstveni_podaciTableAdapter zdravstveniPodaciTableAdapter;
        private PI2324_msokser22_DBDataSet2.Zdravstveni_podaciDataTable zdravstveniPodaciDataTable;

        public OsobniZdravstveniPodaciModel()
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
                throw new Exception("Greška prilikom učitavanja podataka.", ex);
            }
        }

        public DataTable DohvatiPodatke()
        {
            return zdravstveniPodaciDataTable;
        }

        public void ObrisiPodatak(int id)
        {
            try
            {
                // Brisanje iz DataTable-a
                var redakZaBrisanje = zdravstveniPodaciDataTable.FindByidZdravstveniPodaci(id);
                if (redakZaBrisanje != null)
                {
                    redakZaBrisanje.Delete();
                }

                // Brisanje iz baze podataka
                using (var connection = new SqlConnection("YOUR_CONNECTION_STRING")) // Zamijeni s tvojom connection stringom
                {
                    connection.Open();
                    using (var command = new SqlCommand("DELETE FROM Zdravstveni_podaci WHERE idZdravstveniPodaci = @ID", connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška prilikom brisanja podataka.", ex);
            }
        }

        public void PohraniPromjene()
        {
            try
            {
                zdravstveniPodaciTableAdapter.Update(zdravstveniPodaciDataTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Greška prilikom pohranjivanja podataka.", ex);
            }
        }

        public List<string> DohvatiNazivaStupaca()
        {
            return zdravstveniPodaciDataTable.Columns.Cast<DataColumn>()
                .Select(column => column.ColumnName) // Ili column.Caption za prikazni naziv
                .ToList();
        }
    }
}
