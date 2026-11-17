using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace fantasybestariumTorokDonat
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString;

        public SzornyAdatbazis()
        {
            this.connectionString = "Data Source=.;Initial Catalog=fantasybestariumdb;Integrated Security=True;";
        }

        public List<Szorny> Feltolt() {
            List<Szorny> szornyek = new List<Szorny>();

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM szornyek", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Szorny szorny = new Szorny(
                        Convert.ToInt32(reader["id"].ToString()),
                        reader["Nev"].ToString(),
                        Convert.ToInt32(reader["VeszelyessegiSzint"].ToString()),
                        reader["Elohely"].ToString(),
                        reader["FoGyengeseg"].ToString(),
                        reader["LeggyakoribbZsakmany"].ToString(),
                        (Convert.ToInt32(reader["VeszelyesE"].ToString())==1
                        ));

                    szornyek.Add(szorny);
                }

                reader.Close();
            }

            return szornyek;
        }
    }
}
