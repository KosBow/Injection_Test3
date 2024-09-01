using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Test2
{
    public interface IDatabaseService
    {
        bool ValidateUser(string username, string password);
    }

    public class DatabaseService : IDatabaseService
    {
        public bool ValidateUser(string username, string password)
        {
            string server = "localhost";
            string database = "users";
            string dbUser = "root";
            string dbPass = "hattina123";
            string connString = $"SERVER={server};DATABASE={database};UID={dbUser};PASSWORD={dbPass};";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string sqlQuery = "SELECT * FROM users WHERE user_username = @user AND user_password = @pass;";
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read();
                        }
                    }
                    catch
                    {
                        // Handle exception (log it, rethrow it, etc.)
                        throw;
                    }
                }
            }
        }
    }

}
