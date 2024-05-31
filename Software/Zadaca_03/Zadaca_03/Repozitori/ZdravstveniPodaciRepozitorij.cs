using System;
using System.Data.SqlClient;
using Zadaca_03.Modeli;
using Zadaca_03;

namespace ZdravstveniPodaciRepozitorij
{
    public class ZdravstveniPodaciRepozitorij
    {
       
        public static void InsertOsobneBiljeske(ZdravstveniPodaci podaci)
        {
            string sql = $"INSERT INTO Zdravstveni_podaci (Osobne_bilješke) " +
                         $"VALUES ('{podaci.OsobneBiljeske}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


       
        public static void UpdateTermini(int ID_podataka, DateTime termin)
        {
            string sql = $"UPDATE Zdravstveni_podaci " +
                         $"SET Termin = '{termin.ToString("yyyy-MM-dd ")}' " +
                         $"WHERE ID_podataka = {ID_podataka}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }



        
        public static void DeleteOsobneBiljeske(int ID_podataka)
        {
            string sql = $"DELETE FROM Zdravstveni_podaci WHERE ID_podataka = {ID_podataka} AND Osobne_bilješke IS NOT NULL";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
