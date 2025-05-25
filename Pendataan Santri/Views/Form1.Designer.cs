namespace Pendataan_Santri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonEdit = new Button();
            buttonTambah = new Button();
            buttonHapus = new Button();
            txtNama = new TextBox();
            cboJenisKelamin = new ComboBox();
            dtpTanggalLahir = new DateTimePicker();
            txtSekolah = new TextBox();
            txtNamaAyah = new TextBox();
            txtNamaIbu = new TextBox();
            txtAlamat = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textCari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 0;
            label1.Text = "Pendataan Santri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Lengkap   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "Jenis Kelamin      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Location = new Point(13, 116);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Lahir      :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Location = new Point(16, 151);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 4;
            label5.Text = "Sekolah              :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Location = new Point(16, 185);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 5;
            label6.Text = "Nama Ayah        :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Info;
            label7.Location = new Point(17, 217);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 6;
            label7.Text = "Nama Ibu           :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Info;
            label8.Location = new Point(21, 250);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 7;
            label8.Text = "Alamat              :";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.Info;
            buttonEdit.Location = new Point(279, 287);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = SystemColors.Info;
            buttonTambah.Location = new Point(128, 288);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(94, 29);
            buttonTambah.TabIndex = 10;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = SystemColors.Info;
            buttonHapus.Location = new Point(430, 288);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(94, 29);
            buttonHapus.TabIndex = 11;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // txtNama
            // 
            txtNama.BackColor = SystemColors.Info;
            txtNama.Location = new Point(148, 48);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(247, 27);
            txtNama.TabIndex = 12;
            // 
            // cboJenisKelamin
            // 
            cboJenisKelamin.BackColor = SystemColors.Info;
            cboJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJenisKelamin.FormattingEnabled = true;
            cboJenisKelamin.Items.AddRange(new object[] { "Laki - Laki", "Perempuan" });
            cboJenisKelamin.Location = new Point(148, 81);
            cboJenisKelamin.Name = "cboJenisKelamin";
            cboJenisKelamin.Size = new Size(247, 28);
            cboJenisKelamin.TabIndex = 13;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(148, 116);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(247, 27);
            dtpTanggalLahir.TabIndex = 14;
            // 
            // txtSekolah
            // 
            txtSekolah.BackColor = SystemColors.Info;
            txtSekolah.Location = new Point(148, 150);
            txtSekolah.Name = "txtSekolah";
            txtSekolah.Size = new Size(247, 27);
            txtSekolah.TabIndex = 15;
            // 
            // txtNamaAyah
            // 
            txtNamaAyah.BackColor = SystemColors.Info;
            txtNamaAyah.Location = new Point(148, 183);
            txtNamaAyah.Name = "txtNamaAyah";
            txtNamaAyah.Size = new Size(247, 27);
            txtNamaAyah.TabIndex = 16;
            // 
            // txtNamaIbu
            // 
            txtNamaIbu.BackColor = SystemColors.Info;
            txtNamaIbu.Location = new Point(148, 216);
            txtNamaIbu.Name = "txtNamaIbu";
            txtNamaIbu.Size = new Size(247, 27);
            txtNamaIbu.TabIndex = 17;
            // 
            // txtAlamat
            // 
            txtAlamat.BackColor = SystemColors.Info;
            txtAlamat.Location = new Point(148, 249);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(247, 27);
            txtAlamat.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 303);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(315, 662);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonTambah_Click;
            // 
            // textCari
            // 
            textCari.Location = new Point(580, 288);
            textCari.Name = "textCari";
            textCari.Size = new Size(94, 27);
            textCari.TabIndex = 22;
            textCari.Text = "Cari";
            textCari.TextAlign = HorizontalAlignment.Center;
            textCari.TextChanged += textCari_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 703);
            Controls.Add(textCari);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtAlamat);
            Controls.Add(txtNamaIbu);
            Controls.Add(txtNamaAyah);
            Controls.Add(txtSekolah);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(cboJenisKelamin);
            Controls.Add(txtNama);
            Controls.Add(buttonHapus);
            Controls.Add(buttonTambah);
            Controls.Add(buttonEdit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonTambah;
        private Button buttonEdit;
        private Button buttonHapus;
        private TextBox txtNama;
        private ComboBox cboJenisKelamin;
        private DateTimePicker dtpTanggalLahir;
        private TextBox txtSekolah;
        private TextBox txtNamaAyah;
        private TextBox txtNamaIbu;
        private TextBox txtAlamat;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textCari;
        private Button button2;
    }
}
