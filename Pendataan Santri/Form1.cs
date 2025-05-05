using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pendataan_Santri
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;user id=root;password=;database=pendataan_santri;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM santri", conn);
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }

            dataGridView1.Columns["id"].Visible = false; // Sembunyikan kolom id
        }

        private void ClearFields()
        {
            txtNama.Clear();
            cboJenisKelamin.SelectedIndex = -1;
            dtpTanggalLahir.Value = DateTime.Today;
            txtSekolah.Clear();
            txtNamaAyah.Clear();
            txtNamaIbu.Clear();
            txtAlamat.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO santri (nama, jenis_kelamin, tanggal_lahir, sekolah, nama_ayah, nama_ibu, alamat) VALUES (@nama, @jk, @ttl, @sekolah, @ayah, @ibu, @alamat)", conn);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@jk", cboJenisKelamin.Text);
                cmd.Parameters.AddWithValue("@ttl", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sekolah", txtSekolah.Text);
                cmd.Parameters.AddWithValue("@ayah", txtNamaAyah.Text);
                cmd.Parameters.AddWithValue("@ibu", txtNamaIbu.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                ClearFields();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNama.Text = row.Cells["nama"].Value.ToString();
                cboJenisKelamin.Text = row.Cells["jenis_kelamin"].Value.ToString();
                dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells["tanggal_lahir"].Value);
                txtSekolah.Text = row.Cells["sekolah"].Value.ToString();
                txtNamaAyah.Text = row.Cells["nama_ayah"].Value.ToString();
                txtNamaIbu.Text = row.Cells["nama_ibu"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("UPDATE santri SET nama=@nama, jenis_kelamin=@jk, tanggal_lahir=@ttl, sekolah=@sekolah, nama_ayah=@ayah, nama_ibu=@ibu, alamat=@alamat WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@jk", cboJenisKelamin.Text);
                    cmd.Parameters.AddWithValue("@ttl", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@sekolah", txtSekolah.Text);
                    cmd.Parameters.AddWithValue("@ayah", txtNamaAyah.Text);
                    cmd.Parameters.AddWithValue("@ibu", txtNamaIbu.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadData();
                    ClearFields();
                    MessageBox.Show("Data berhasil diubah");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengubah data: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        cmd = new MySqlCommand("DELETE FROM santri WHERE id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        LoadData();
                        ClearFields();
                        MessageBox.Show("Data berhasil dihapus");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message);
                        conn.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}
