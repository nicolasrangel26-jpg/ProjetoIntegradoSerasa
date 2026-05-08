namespace Menu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkSenha = new LinkLabel();
            linkCadastrar = new LinkLabel();
            btnFechar = new Button();
            chkSenha = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1405, 139);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(549, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 80);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(652, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(678, 577);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(233, 294);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(216, 23);
            txtLogin.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(233, 389);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(216, 23);
            txtSenha.TabIndex = 7;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(233, 449);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(216, 38);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 256);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(311, 354);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 10;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(311, 249);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 11;
            label4.Text = "Login";
            label4.Click += label4_Click;
            // 
            // linkSenha
            // 
            linkSenha.AutoSize = true;
            linkSenha.Location = new Point(280, 514);
            linkSenha.Name = "linkSenha";
            linkSenha.Size = new Size(117, 15);
            linkSenha.TabIndex = 12;
            linkSenha.TabStop = true;
            linkSenha.Text = "Esqueceu sua senha?";
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Location = new Point(299, 548);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(72, 15);
            linkCadastrar.TabIndex = 13;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastre-se ";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(233, 617);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(216, 61);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.Location = new Point(430, 394);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(15, 14);
            chkSenha.TabIndex = 15;
            chkSenha.UseVisualStyleBackColor = true;
            chkSenha.CheckedChanged += chkSenha_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SeaShell;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1331, 737);
            Controls.Add(chkSenha);
            Controls.Add(btnFechar);
            Controls.Add(linkCadastrar);
            Controls.Add(linkSenha);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkSenha;
        private LinkLabel linkCadastrar;
        private Button btnFechar;
        private CheckBox chkSenha;
    }
}