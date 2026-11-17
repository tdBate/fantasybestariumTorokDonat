using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace fantasybestariumTorokDonat
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString;

        public SzornyAdatbazis()
        {
            this.connectionString = "Server=127.0.0.1;Database=fantasybestariumdb;User Id=root;Password=;";
        }

        public List<Szorny> Feltolt()
        {
            List<Szorny> szornyek = new List<Szorny>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM szornyek", connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Szorny szorny = new Szorny(
                                Convert.ToInt32(reader["id"]),
                                reader["Nev"].ToString(),
                                Convert.ToInt32(reader["VeszelyessegiSzint"]),
                                reader["Elohely"].ToString(),
                                reader["FoGyengeseg"].ToString(),
                                reader["LeggyakoribbZsakmany"].ToString(),
                                Convert.ToInt32(reader["VeszelyesE"]) == 1
                            );

                            szornyek.Add(szorny);
                        }
                    }
                }
            

            return szornyek;
        }
    }
}
