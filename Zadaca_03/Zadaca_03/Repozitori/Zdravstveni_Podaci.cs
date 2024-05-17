using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Zadaca_03.Modeli;

namespace Zadaca_03.Repozitori
{
    public static class DB
    {
        public static string ConnectionString { get; } = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";
    }

    public class Zdravstveni_Podaci
    {
        public static ZdravstveniPodaci GetZdravstveniPodaci(int id)
        {
            ZdravstveniPodaci podaci = null;

            string sql = "SELECT * FROM Zdravstveni_podaci WHERE ID_podataka = @Id";
            using (SqlConnection connection = new SqlConnection(DB.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            podaci = CreateObject(reader);
                        }
                    }
                }
            }
            return podaci;
        }

        public static List<ZdravstveniPodaci> GetZdravstveniPodaci()
        {
            var podaciList = new List<ZdravstveniPodaci>();

            string sql = "SELECT * FROM Zdravstveni_podaci";
            using (SqlConnection connection = new SqlConnection(DB.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ZdravstveniPodaci podaci = CreateObject(reader);
                            podaciList.Add(podaci);
                        }
                    }
                }
            }
            return podaciList;
        }

        private static ZdravstveniPodaci CreateObject(SqlDataReader reader)
        {
            int id = reader["ID_podataka"] != DBNull.Value ? int.Parse(reader["ID_podataka"].ToString()) : 0;
            string opisSimtoma = reader["Opis_simtoma"].ToString();
            string rezultatiKrvnePretrage = reader["Rezultati_krvne_pretrage"].ToString();
            string informacijeOalergiji = reader["Informacije_o_alergiji"].ToString();
            string popisPrepisanihLijekova = reader["Popis_prepisanih_lijekova"].ToString();
            string napomeneLiječnika = reader["Napomene_liječnika"].ToString();
            string dijagnoza = reader["Dijagnoza"].ToString();
            string planLiječenja = reader["Plan_liječenja"].ToString();
            string osobneBilješke = reader["Osobne_bilješke"].ToString();
            DateTime? termin = reader["Termin"] != DBNull.Value ? (DateTime?)reader["Termin"] : null;

            var podaci = new ZdravstveniPodaci
            {
                ID_podataka = id,
                Opis_simtoma = opisSimtoma,
                Rezultati_krvne_pretrage = rezultatiKrvnePretrage,
                Informacije_o_alergiji = informacijeOalergiji,
                Popis_prepisanih_lijekova = popisPrepisanihLijekova,
                Napomene_liječnika = napomeneLiječnika,
                Dijagnoza = dijagnoza,
                Plan_liječenja = planLiječenja,
                Osobne_bilješke = osobneBilješke,
                Termin = termin
            };

            return podaci;
        }
    }
}
