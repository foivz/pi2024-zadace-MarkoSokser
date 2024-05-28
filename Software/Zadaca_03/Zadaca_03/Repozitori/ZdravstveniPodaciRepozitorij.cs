using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Zadaca_03.Modeli;

namespace Zadaca_03.Repozitori
{
    public class ZdravstveniPodaciRepozitorij
    {
        // Metoda za dohvaćanje zdravstvenih podataka po ID-u
        public static ZdravstveniPodaci GetZdravstveniPodaci(int id)
        {
            ZdravstveniPodaci podaci = null;
            string sql = $"SELECT * FROM Zdravstveni_podaci WHERE ID_podataka = @ID_podataka";
            DB.OpenConnection();

            var command = new SqlCommand(sql, DB.Connection);
            command.Parameters.AddWithValue("@ID_podataka", id);
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                podaci = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return podaci;
        }

        // Metoda za dohvaćanje svih zdravstvenih podataka
        public static List<ZdravstveniPodaci> GetAllZdravstveniPodaci()
        {
            List<ZdravstveniPodaci> podaciList = new List<ZdravstveniPodaci>();
            string sql = "SELECT * FROM Zdravstveni_podaci";
            DB.OpenConnection();

            var command = new SqlCommand(sql, DB.Connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ZdravstveniPodaci podaci = CreateObject(reader);
                podaciList.Add(podaci);
            }
            reader.Close();
            DB.CloseConnection();
            return podaciList;
        }

        // Metoda za ažuriranje osobnih bilješki u zdravstvenim podacima
        public static void UpdateOsobneBiljeske(int id, string noveBiljeske, DateTime? noviTermin)
        {
            string sql = "UPDATE Zdravstveni_podaci SET Osobne_bilješke = @Osobne_bilješke";
            if (noviTermin.HasValue)
            {
                sql += ", Termin = @Termin";
            }
            sql += " WHERE ID_podataka = @ID_podataka";
            string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Osobne_bilješke", noveBiljeske);
                    if (noviTermin.HasValue)
                    {
                        command.Parameters.AddWithValue("@Termin", noviTermin.Value);
                    }
                    command.Parameters.AddWithValue("@ID_podataka", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        // Pomoćna metoda za kreiranje objekta ZdravstveniPodaci iz SqlDataReader-a
        private static ZdravstveniPodaci CreateObject(SqlDataReader reader)
        {
            return new ZdravstveniPodaci
            {
                ID_podataka = int.Parse(reader["ID_podataka"].ToString()),
                Opis_simtoma = reader["Opis_simtoma"].ToString(),
                Rezultati_krvne_pretrage = reader["Rezultati_krvne_pretrage"].ToString(),
                Informacije_o_alergiji = reader["Informacije_o_alergiji"].ToString(),
                Popis_prepisanih_lijekova = reader["Popis_prepisanih_lijekova"].ToString(),
                Napomene_liječnika = reader["Napomene_liječnika"].ToString(),
                Dijagnoza = reader["Dijagnoza"].ToString(),
                Plan_liječenja = reader["Plan_liječenja"].ToString(),
                Osobne_bilješke = reader["Osobne_bilješke"].ToString(),
                Termin = reader["Termin"] != DBNull.Value ? (DateTime?)DateTime.Parse(reader["Termin"].ToString()) : null
            };
        }
    }
}
