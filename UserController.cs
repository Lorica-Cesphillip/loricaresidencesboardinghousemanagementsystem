using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lorica_Residences_Rental_Management_System
{
    internal class UserController
    {
        private static string username = "";
        private static string password = "";

        public async Task<int> LogInValidationAsync(string username, string password)
        {
            await Task.Delay(1); // Simulating async work
            int count = 0;
            SQLController conn = new SQLController("localhost", "loricaresidence_boardinghouse", "rental", "LoricaHouse12345");

            try
            {
                string login = "SELECT COUNT(1) FROM user WHERE username = @username AND hashed_password = @password";

                MySqlParameter[] parametros =
                {
                    new MySqlParameter("@username", username),
                    new MySqlParameter("@password", password)
                };

                object result = await conn.ExecuteScalarAsync(login, parametros); // Await the async method

                if (result != null && result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message + "Error Number: " + ex.Number);
            }
            return count;
        }

        public static string SHA256Converter(string securepass)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (SHA256 hash = SHA256.Create())
            {
                Encoding encoding = Encoding.UTF8;
                byte[] result = hash.ComputeHash(encoding.GetBytes(securepass));

                foreach (byte b in result)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
            }
            return stringBuilder.ToString();
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
