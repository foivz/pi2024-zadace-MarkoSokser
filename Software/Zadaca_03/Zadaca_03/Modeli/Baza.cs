using System;
using System.Data.SqlClient;

namespace Zadaca_03
{
    public static class DB
    {
        private static readonly string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";
        public static SqlConnection Connection { get; private set; }

        // Metoda za otvaranje konekcije
        public static void OpenConnection()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new SqlConnection(connectionString);
                }

                if (Connection.State != System.Data.ConnectionState.Open)
                {
                    Connection.Open();
                }
            }
            catch (SqlException ex)
            {
                // Logiranje greške ili dalja obrada
                Console.WriteLine("Error opening connection: " + ex.Message);
                throw;
            }
        }

        // Metoda za zatvaranje konekcije
        public static void CloseConnection()
        {
            try
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            catch (SqlException ex)
            {
                // Logiranje greške ili dalja obrada
                Console.WriteLine("Error closing connection: " + ex.Message);
                throw;
            }
        }

        // Metoda za dohvaćanje SqlDataReader-a
        public static SqlDataReader GetDataReader(string sql)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    return command.ExecuteReader();
                }
            }
            catch (SqlException ex)
            {
                // Logiranje greške ili dalja obrada
                Console.WriteLine("Error executing command: " + ex.Message);
                throw;
            }
        }

        // Metoda za izvršavanje komande (Insert, Update, Delete)
        public static void ExecuteCommand(string sql)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Logiranje greške ili dalja obrada
                Console.WriteLine("Error executing command: " + ex.Message);
                throw;
            }
        }
    }
}
