using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BukuApps.Helpers;
using BukuApps.Models;
using System;

namespace BukuApps.Controllers
{
    public class PenggunaController
    {
        public List<Pengguna> GetAllPengguna()
        {
            var list = new List<Pengguna>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM Pengguna", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Pengguna
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()
                    });
                }
            }
            return list;
        }

        public void TambahPengguna(Pengguna pengguna)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO Pengguna (Username, Password) VALUES (@username, @password)", conn);
                cmd.Parameters.AddWithValue("@username", pengguna.Username);
                cmd.Parameters.AddWithValue("@password", pengguna.Password);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
