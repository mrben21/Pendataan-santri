using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormMain : Form
    {
        private Label labelWelcome;
        private Button buttonLogout;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelWelcome = new Label();
            this.buttonLogout = new Button();
            this.SuspendLayout();

            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelWelcome.Location = new Point(50, 30);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new Size(260, 41);
            this.labelWelcome.Text = "Selamat Datang!";

            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.buttonLogout.Location = new Point(110, 100);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new Size(120, 35);
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new EventHandler(this.buttonLogout_Click);

            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.ClientSize = new Size(350, 180);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonLogout);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Beranda";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // atau kembali ke Form Login jika diinginkan
        }
    }
}