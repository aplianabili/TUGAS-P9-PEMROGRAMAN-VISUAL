using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BukuApps.Helpers;


namespace BukuApps
{
    public class BukuRepository
    {
        // Mendapatkan daftar buku
        public List<Buku> GetAllBuku()
        {
            List<Buku> bukuList = new List<Buku>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM data_buku";  // Sesuaikan dengan nama tabel Anda
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bukuList.Add(new Buku(
                            reader["judul"].ToString(),
                            reader["penulis"].ToString(),
                            reader["penerbit"].ToString(),
                            reader["tahun"].ToString(),
                            Convert.ToInt32(reader["id"]),
                            reader["status"].ToString() // Menambahkan status
                        ));
                    }
                }
            }
            return bukuList;
        }

        // Menambah buku baru
        public void InsertBuku(Buku buku)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO data_buku (judul, penulis, penerbit, tahun, status) VALUES (@judul, @penulis, @penerbit, @tahun, @status)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@judul", buku.Judul);
                cmd.Parameters.AddWithValue("@penulis", buku.Penulis);
                cmd.Parameters.AddWithValue("@penerbit", buku.Penerbit);
                cmd.Parameters.AddWithValue("@tahun", buku.Tahun);
                cmd.Parameters.AddWithValue("@status", buku.Status); // Menambahkan status
                cmd.ExecuteNonQuery();
            }
        }

        // Mengupdate data buku
        public void UpdateBuku(Buku buku)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE data_buku SET judul=@judul, penulis=@penulis, penerbit=@penerbit, tahun=@tahun, status=@status WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@judul", buku.Judul);
                cmd.Parameters.AddWithValue("@penulis", buku.Penulis);
                cmd.Parameters.AddWithValue("@penerbit", buku.Penerbit);
                cmd.Parameters.AddWithValue("@tahun", buku.Tahun);
                cmd.Parameters.AddWithValue("@status", buku.Status); // Menambahkan status
                cmd.Parameters.AddWithValue("@id", buku.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Menghapus buku
        public void DeleteBuku(int id)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM data_buku WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Menandai buku sebagai dipinjam
        public void PinjamBuku(int idBuku)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE data_buku SET status = 'Dipinjam' WHERE id = @idBuku";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idBuku", idBuku);
                cmd.ExecuteNonQuery();
            }
        }

        // Menandai buku sebagai tersedia setelah dikembalikan
        public void KembalikanBuku(int idBuku)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE data_buku SET status = 'Tersedia' WHERE id = @idBuku";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idBuku", idBuku);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
