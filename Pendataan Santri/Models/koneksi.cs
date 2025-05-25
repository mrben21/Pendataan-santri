using MySql.Data.MySqlClient;

namespace Pendataan_Santri
{
    public static class Database
    {
        private static readonly string connectionString = "server=localhost;user id=root;password=;database=pendataan_santri;";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
