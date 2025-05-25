using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pendataan_Santri
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class FormLogin : Form
    {
        // Data login disimpan dalam dictionary (username => password)
        private Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "admin", "admin123" },
        };

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 formPendataan = new Form1();
                formPendataan.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Periksa apakah username ada dan password-nya cocok
            return users.ContainsKey(username) && users[username] == password;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
