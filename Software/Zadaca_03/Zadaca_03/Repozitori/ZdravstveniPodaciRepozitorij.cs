using System;
using System.Data.SqlClient;
using Zadaca_03.Modeli;
using Zadaca_03;

namespace ZdravstveniPodaciRepozitorij
{
    public class ZdravstveniPodaciRepozitorij
    {
        // Metoda za umetanje novih zdravstvenih podataka samo u stupac Osobne bilješke
        public static void InsertOsobneBiljeske(ZdravstveniPodaci podaci)
        {
            string sql = $"INSERT INTO Zdravstveni_podaci (Osobne_bilješke) " +
                         $"VALUES ('{podaci.OsobneBiljeske}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        

        // Metoda za ažuriranje postojećih zdravstvenih podataka samo u stupcu Termini
        public static void UpdateTermini(ZdravstveniPodaci podaci)
        {
            string sql = $"UPDATE Zdravstveni_podaci " +
                         $"SET Termin = '{podaci.Termin?.ToString("yyyy-MM-dd HH:mm:ss") ?? "NULL"}' " +
                         $"WHERE ID_podataka = {podaci.OsobneBiljeske}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        // Metoda za brisanje zdravstvenih podataka samo u stupcu Osobne bilješke
        public static void DeleteOsobneBiljeske(int ID_podataka)
        {
            string sql = $"DELETE FROM Zdravstveni_podaci WHERE ID_podataka = {ID_podataka} AND Osobne_bilješke IS NOT NULL";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
