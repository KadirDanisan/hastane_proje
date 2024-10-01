using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_proje
{
    class sqlbaglantisi
    {

        public void VerileriGoster()
        {
            using (var connection = baglanti())
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM tablename", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0)); // 1. sütunu al
                        }
                    }
                }
            }
        }

        public NpgsqlConnection baglanti()
        {
            var connString = "Host=localhost;Username=postgres;Password=1234;Database=Hastane_proje";
            var conn = new NpgsqlConnection(connString);
            conn.Open(); // Bağlantıyı aç
            return conn; // Açık bağlantıyı döndür
        }
    }
}
