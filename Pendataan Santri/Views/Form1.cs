using System;
using System.Data;
using System.Windows.Forms;

namespace Pendataan_Santri
{
    public partial class Form1 : Form
    {
        private SantriService santriService = new SantriService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.DataSource = santriService.GetAllSantri();
                dataGridView1.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                santriService.TambahSantri(
                    txtNama.Text,
                    cboJenisKelamin.Text,
                    dtpTanggalLahir.Value.ToString("yyyy-MM-dd"),
                    txtSekolah.Text,
                    txtNamaAyah.Text,
                    txtNamaIbu.Text,
                    txtAlamat.Text
                );

                LoadData();
                ClearFields();
                MessageBox.Show("Data berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                try
                {
                    santriService.EditSantri(
                        id,
                        txtNama.Text,
                        cboJenisKelamin.Text,
                        dtpTanggalLahir.Value.ToString("yyyy-MM-dd"),
                        txtSekolah.Text,
                        txtNamaAyah.Text,
                        txtNamaIbu.Text,
                        txtAlamat.Text
                    );

                    LoadData();
                    ClearFields();
                    MessageBox.Show("Data berhasil diubah.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        santriService.HapusSantri(id);
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Data berhasil dihapus.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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

        private void textCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = textCari.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    LoadData();
                }
                else
                {
                    dataGridView1.DataSource = santriService.CariSantri(keyword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}
