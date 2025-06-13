using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BukuApps.Helpers
{
    public static class DatabaseHelper
    {
        private static string connectionString = "server=localhost;user=root;database=buku_db;port=3306;password=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Berhasil terhubung ke database!", "Koneksi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close(); // Ditutup dulu agar bisa dipakai ulang nantinya
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal terhubung ke database:\n{ex.Message}", "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }
    }
}
