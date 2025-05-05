namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 29);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = SystemColors.ScrollBar;
            textBoxUsername.Location = new Point(106, 83);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(209, 30);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.Text = "Username";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = SystemColors.ScrollBar;
            textBoxPassword.Location = new Point(105, 121);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(209, 30);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(160, 167); using System;
            using System.Data;
            using System.Drawing;
            using System.Windows.Forms;
            using MySql.Data.MySqlClient;

namespace FormLogin
    {
        public partial class Form1 : Form
        {
            private Label label1;
            private TextBox textBoxUsername;
            private TextBox textBoxPassword;
            private Button buttonLogin;

            public Form1()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                label1 = new Label();
                textBoxUsername = new TextBox();
                textBoxPassword = new TextBox();
                buttonLogin = new Button();
                SuspendLayout();

                // label1
                label1.AutoSize = true;
                label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
                label1.Location = new Point(160, 29);
                label1.Name = "label1";
                label1.Size = new Size(110, 46);
                label1.TabIndex = 0;
                label1.Text = "Login";

                // textBoxUsername
                textBoxUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                textBoxUsername.Location = new Point(106, 83);
                textBoxUsername.Name = "textBoxUsername";
                textBoxUsername.Size = new Size(209, 30);
                textBoxUsername.TabIndex = 1;
                textBoxUsername.PlaceholderText = "Username";

                // textBoxPassword
                textBoxPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                textBoxPassword.Location = new Point(105, 121);
                textBoxPassword.Name = "textBoxPassword";
                textBoxPassword.Size = new Size(209, 30);
                textBoxPassword.TabIndex = 2;
                textBoxPassword.PlaceholderText = "Password";
                textBoxPassword.UseSystemPasswordChar = true;

                // buttonLogin
                buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                buttonLogin.Location = new Point(160, 167);
                buttonLogin.Name = "buttonLogin";
                buttonLogin.Size = new Size(94, 29);
                buttonLogin.TabIndex = 3;
                buttonLogin.Text = "Login";
                buttonLogin.UseVisualStyleBackColor = true;
                buttonLogin.Click += buttonLogin_Click;

                // Form1
                ClientSize = new Size(427, 253);
                Controls.Add(buttonLogin);
                Controls.Add(textBoxPassword);
                Controls.Add(textBoxUsername);
                Controls.Add(label1);
                Name = "Form1";
                StartPosition = FormStartPosition.CenterScreen;
                Text = "Form Login";
                ResumeLayout(false);
                PerformLayout();
            }

            private void buttonLogin_Click(object sender, EventArgs e)
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                string connectionString = "server=localhost;user=root;database=pendataan_santri;password=;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM users WHERE username=@username AND password=@password";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            // Buka form utama (misalnya: FormMain)
                            FormMain formMain = new FormMain();
                            formMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message);
                    }
                }
            }
        }
    }

    buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(427, 253);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
