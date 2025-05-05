namespace Pendataan_Santri
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 23);
            label1.Name = "label1";
            label1.Size = new Size(124, 61);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = SystemColors.Desktop;
            textBoxUsername.Location = new Point(122, 96);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(194, 30);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.Text = "Username";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = SystemColors.Desktop;
            textBoxPassword.Location = new Point(122, 154);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(194, 30);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(177, 214);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 3;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(470, 387);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button button1;
    }
}