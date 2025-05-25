using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Pendataan_Santri
{
    public class SantriService
    {
        public DataTable GetAllSantri()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    string query = "SELECT * FROM santri";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data: " + ex.Message);
            }
            return dt;
        }

        public void TambahSantri(string nama, string jk, string ttl, string sekolah, string ayah, string ibu, string alamat)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    string query = "INSERT INTO santri (nama, jenis_kelamin, tanggal_lahir, sekolah, nama_ayah, nama_ibu, alamat) " +
                                   "VALUES (@nama, @jk, @ttl, @sekolah, @ayah, @ibu, @alamat)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jk", jk);
                    cmd.Parameters.AddWithValue("@ttl", ttl);
                    cmd.Parameters.AddWithValue("@sekolah", sekolah);
                    cmd.Parameters.AddWithValue("@ayah", ayah);
                    cmd.Parameters.AddWithValue("@ibu", ibu);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan data: " + ex.Message);
            }
        }

        public void EditSantri(int id, string nama, string jk, string ttl, string sekolah, string ayah, string ibu, string alamat)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    string query = "UPDATE santri SET nama=@nama, jenis_kelamin=@jk, tanggal_lahir=@ttl, sekolah=@sekolah, " +
                                   "nama_ayah=@ayah, nama_ibu=@ibu, alamat=@alamat WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jk", jk);
                    cmd.Parameters.AddWithValue("@ttl", ttl);
                    cmd.Parameters.AddWithValue("@sekolah", sekolah);
                    cmd.Parameters.AddWithValue("@ayah", ayah);
                    cmd.Parameters.AddWithValue("@ibu", ibu);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengedit data: " + ex.Message);
            }
        }

        public void HapusSantri(int id)
        {
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    string query = "DELETE FROM santri WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data: " + ex.Message);
            }
        }

        public DataTable CariSantri(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    string query = "SELECT * FROM santri WHERE nama LIKE @keyword OR nama_ayah LIKE @keyword OR nama_ibu LIKE @keyword";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mencari data: " + ex.Message);
            }
            return dt;
        }
    }
}
