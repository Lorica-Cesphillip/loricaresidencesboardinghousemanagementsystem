using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Lorica_Residences_Rental_Management_System
{
    internal class SQLController
    {
        public string con;

        public SQLController(string server, string db, string user, string password)
        {
            this.con = $"server={server};user={user};password={password};database={db}";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(con);
        }

        private void PrintException(string ErrorMessage, int ErrorNumber)
        {
            Console.WriteLine($"MySqlException: {ErrorMessage}, Error Number: {ErrorNumber}");
        }

        public async Task<object> ExecuteScalarAsync(string query, MySqlParameter[] parameters = null)
        {
            object result = null;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.Add(param);
                            }
                        }

                        result = await cmd.ExecuteScalarAsync();
                    }
                }
                catch(MySqlException x)
                {
                    PrintException(x.Message, x.Number);
                    throw;
                }
            }
            return result;
        }

        public bool ExecuteNonQuery(string query, MySqlParameter[] param = null)
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);

                    if (param != null)
                    {
                        command.Parameters.AddRange(param);
                    }
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch(MySqlException x)
                {
                    PrintException (x.Message, x.Number);
                    return false;
                }
            }
        }

        public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
                catch (MySqlException x)
                {
                    PrintException(x.Message, x.Number);
                    return null;
                }
            }
        }

        //Retrieve from database and load it to SqlDataGridView
        public MySqlDataReader ExecuteQuery(string query)
        {
            MySqlConnection conn = new MySqlConnection(con);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch(MySqlException x)
            {
                PrintException(x.Message, x.Number);
                return null;
            }
        }

        public void CloseReader(MySqlDataReader reader)
        {
            if (reader != null)
            {
                reader.Close();
            }
        }

        public void CloseCon()
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
