namespace Menu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEstoqueEnco = new Button();
            pictureBox2 = new PictureBox();
            BtnMenuEnco = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            txtEndereço = new TextBox();
            btnSalvar = new Button();
            dgvClientes = new DataGridView();
            Pedido = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnEstoqueEnco);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnMenuEnco);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-6, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 783);
            panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(8, 323);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 517);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 510);
            button5.Name = "button5";
            button5.Size = new Size(197, 66);
            button5.TabIndex = 11;
            button5.Text = "Fechar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 314);
            button4.Name = "button4";
            button4.Size = new Size(205, 66);
            button4.TabIndex = 10;
            button4.Text = "Encomendas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 422);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 224);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnEstoqueEnco
            // 
            btnEstoqueEnco.BackColor = Color.FromArgb(64, 64, 64);
            btnEstoqueEnco.FlatStyle = FlatStyle.Popup;
            btnEstoqueEnco.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstoqueEnco.ForeColor = Color.White;
            btnEstoqueEnco.Location = new Point(3, 212);
            btnEstoqueEnco.Name = "btnEstoqueEnco";
            btnEstoqueEnco.Size = new Size(197, 66);
            btnEstoqueEnco.TabIndex = 4;
            btnEstoqueEnco.Text = "Estoque";
            btnEstoqueEnco.UseVisualStyleBackColor = false;
            btnEstoqueEnco.Click += btnEstoqueEnco_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BtnMenuEnco
            // 
            BtnMenuEnco.BackColor = Color.FromArgb(80, 80, 80);
            BtnMenuEnco.FlatStyle = FlatStyle.Popup;
            BtnMenuEnco.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMenuEnco.ForeColor = Color.White;
            BtnMenuEnco.Location = new Point(3, 408);
            BtnMenuEnco.Name = "BtnMenuEnco";
            BtnMenuEnco.Size = new Size(197, 66);
            BtnMenuEnco.TabIndex = 5;
            BtnMenuEnco.Text = "Cadastro ";
            BtnMenuEnco.UseVisualStyleBackColor = false;
            BtnMenuEnco.Click += BtnMenuEnco_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Location = new Point(90, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 567);
            panel3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-47, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 132);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(658, 24);
            label1.Name = "label1";
            label1.Size = new Size(272, 80);
            label1.TabIndex = 2;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 160);
            label2.Name = "label2";
            label2.Size = new Size(83, 29);
            label2.TabIndex = 4;
            label2.Text = "Nome ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 208);
            label3.Name = "label3";
            label3.Size = new Size(57, 29);
            label3.TabIndex = 5;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 263);
            label4.Name = "label4";
            label4.Size = new Size(112, 29);
            label4.TabIndex = 6;
            label4.Text = "Telefone ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(218, 310);
            label5.Name = "label5";
            label5.Size = new Size(115, 29);
            label5.TabIndex = 7;
            label5.Text = "Endereço";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(339, 269);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(235, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(339, 214);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(235, 23);
            txtCPF.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(339, 166);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(342, 23);
            txtNome.TabIndex = 10;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(339, 316);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(461, 23);
            txtEndereço.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(339, 383);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 44);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Pedido, Quantidade, Obs });
            dgvClientes.Location = new Point(872, 235);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(418, 409);
            dgvClientes.TabIndex = 22;
            // 
            // Pedido
            // 
            Pedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pedido.HeaderText = "Pedido";
            Pedido.Name = "Pedido";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 94;
            // 
            // Obs
            // 
            Obs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Obs.HeaderText = "Obs";
            Obs.Name = "Obs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1027, 160);
            label6.Name = "label6";
            label6.Size = new Size(119, 34);
            label6.TabIndex = 23;
            label6.Text = "Clientes";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1331, 737);
            Controls.Add(label6);
            Controls.Add(dgvClientes);
            Controls.Add(btnSalvar);
            Controls.Add(txtEndereço);
            Controls.Add(txtNome);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnEstoqueEnco;
        private PictureBox pictureBox2;
        private Button BtnMenuEnco;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtEndereço;
        private Button btnSalvar;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Pedido;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Obs;
        private Label label6;
    }
}