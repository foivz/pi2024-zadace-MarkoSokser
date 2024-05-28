using System;
using System.Data.SqlClient;

namespace Zadaca_03
{
    public static class DB
    {
        public static SqlConnection Connection { get; private set; }

        // Metoda za otvaranje konekcije
        public static void OpenConnection()
        {
            if (Connection == null)
            {
                // Zamijenite connectionString stvarnim podatcima vaše baze podataka
                string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";
                Connection = new SqlConnection(connectionString);
            }

            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        // Metoda za zatvaranje konekcije
        public static void CloseConnection()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        // Metoda za dohvaćanje SqlDataReader-a
        public static SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql, Connection);
            return command.ExecuteReader();
        }
    }
}
