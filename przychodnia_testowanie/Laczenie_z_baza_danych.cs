using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace przychodnia_testowanie
{
    public class Laczenie_z_baza_danych
    {
        private string connectionString = "Server=127.0.0.1;Database=clinic;User ID=root;Password=;SslMode=none;";

        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        if (query.Trim().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                adapter.Fill(dataTable);
                            }
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd zapytania: " + ex.Message);
                }
            }
            return dataTable;
        }
    }
}
