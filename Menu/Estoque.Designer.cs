namespace Menu
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnCadastroEstoque = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEncoEstoque = new Button();
            btnMenuEstoque = new Button();
            panel3 = new Panel();
            dgvTabelaEstoque = new DataGridView();
            txtNomeProduto = new TextBox();
            txtQuant = new TextBox();
            btnAdicionarEstoque = new Button();
            btnRemoveEstoque = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            btnEditarEstoque = new Button();
            dateTimePicker2 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabelaEstoque).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-47, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 132);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(523, 29);
            label1.Name = "label1";
            label1.Size = new Size(568, 80);
            label1.TabIndex = 0;
            label1.Text = "Estoque de Produtos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(btnCadastroEstoque);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnEncoEstoque);
            panel2.Controls.Add(btnMenuEstoque);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-6, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 783);
            panel2.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 237);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 227);
            button2.Name = "button2";
            button2.Size = new Size(197, 66);
            button2.TabIndex = 0;
            button2.Text = " Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(13, 335);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(42, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(80, 80, 80);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 540);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // btnCadastroEstoque
            // 
            btnCadastroEstoque.FlatStyle = FlatStyle.Popup;
            btnCadastroEstoque.Font = new Font("Times New Roman", 15.75F);
            btnCadastroEstoque.ForeColor = Color.White;
            btnCadastroEstoque.Location = new Point(3, 322);
            btnCadastroEstoque.Name = "btnCadastroEstoque";
            btnCadastroEstoque.Size = new Size(197, 66);
            btnCadastroEstoque.TabIndex = 1;
            btnCadastroEstoque.Text = "     Cadastro";
            btnCadastroEstoque.UseVisualStyleBackColor = true;
            btnCadastroEstoque.Click += btnCadastroEstoque_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(80, 80, 80);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 531);
            button1.Name = "button1";
            button1.Size = new Size(197, 66);
            button1.TabIndex = 3;
            button1.Text = "      Estoque";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 643);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 435);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnEncoEstoque
            // 
            btnEncoEstoque.FlatStyle = FlatStyle.Popup;
            btnEncoEstoque.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncoEstoque.ForeColor = Color.White;
            btnEncoEstoque.Location = new Point(3, 426);
            btnEncoEstoque.Name = "btnEncoEstoque";
            btnEncoEstoque.Size = new Size(197, 66);
            btnEncoEstoque.TabIndex = 2;
            btnEncoEstoque.Text = "        Encomendas";
            btnEncoEstoque.UseVisualStyleBackColor = true;
            btnEncoEstoque.Click += btnEncoEstoque_Click;
            // 
            // btnMenuEstoque
            // 
            btnMenuEstoque.FlatStyle = FlatStyle.Popup;
            btnMenuEstoque.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuEstoque.ForeColor = Color.White;
            btnMenuEstoque.Location = new Point(3, 629);
            btnMenuEstoque.Name = "btnMenuEstoque";
            btnMenuEstoque.Size = new Size(197, 66);
            btnMenuEstoque.TabIndex = 4;
            btnMenuEstoque.Text = "  Fechar";
            btnMenuEstoque.UseVisualStyleBackColor = true;
            btnMenuEstoque.Click += btnMenuEstoque_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Location = new Point(90, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 567);
            panel3.TabIndex = 11;
            // 
            // dgvTabelaEstoque
            // 
            dgvTabelaEstoque.AllowUserToOrderColumns = true;
            dgvTabelaEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabelaEstoque.Location = new Point(250, 263);
            dgvTabelaEstoque.Name = "dgvTabelaEstoque";
            dgvTabelaEstoque.ReadOnly = true;
            dgvTabelaEstoque.Size = new Size(1037, 463);
            dgvTabelaEstoque.TabIndex = 7;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(298, 197);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(231, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(566, 197);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(124, 23);
            txtQuant.TabIndex = 1;
            // 
            // btnAdicionarEstoque
            // 
            btnAdicionarEstoque.FlatStyle = FlatStyle.System;
            btnAdicionarEstoque.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarEstoque.Location = new Point(939, 191);
            btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            btnAdicionarEstoque.Size = new Size(101, 30);
            btnAdicionarEstoque.TabIndex = 3;
            btnAdicionarEstoque.Text = "ADICIONAR";
            btnAdicionarEstoque.UseVisualStyleBackColor = true;
            btnAdicionarEstoque.Click += btnAdicionarEstoque_Click;
            // 
            // btnRemoveEstoque
            // 
            btnRemoveEstoque.FlatStyle = FlatStyle.System;
            btnRemoveEstoque.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveEstoque.Location = new Point(1046, 191);
            btnRemoveEstoque.Name = "btnRemoveEstoque";
            btnRemoveEstoque.Size = new Size(90, 30);
            btnRemoveEstoque.TabIndex = 4;
            btnRemoveEstoque.Text = "REMOVER";
            btnRemoveEstoque.UseVisualStyleBackColor = true;
            btnRemoveEstoque.Click += btnRemoveEstoque_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(298, 170);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 8;
            label2.Text = "NOME DO PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(566, 170);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 9;
            label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(733, 170);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 10;
            label4.Text = "DATA DE VALIDADE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(287, 154);
            panel5.Name = "panel5";
            panel5.Size = new Size(955, 83);
            panel5.TabIndex = 2;
            // 
            // btnEditarEstoque
            // 
            btnEditarEstoque.FlatStyle = FlatStyle.System;
            btnEditarEstoque.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEstoque.Location = new Point(1142, 191);
            btnEditarEstoque.Name = "btnEditarEstoque";
            btnEditarEstoque.Size = new Size(90, 30);
            btnEditarEstoque.TabIndex = 5;
            btnEditarEstoque.Text = "EDITAR";
            btnEditarEstoque.UseVisualStyleBackColor = true;
            btnEditarEstoque.Click += btnEditarEstoque_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.ImeMode = ImeMode.On;
            dateTimePicker2.Location = new Point(733, 197);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(143, 23);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1347, 776);
            Controls.Add(btnEditarEstoque);
            Controls.Add(label4);
            Controls.Add(btnRemoveEstoque);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdicionarEstoque);
            Controls.Add(txtQuant);
            Controls.Add(txtNomeProduto);
            Controls.Add(dgvTabelaEstoque);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += Estoque_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabelaEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnEncoEstoque;
        private Button btnMenuEstoque;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvTabelaEstoque;
        private PictureBox pictureBox3;
        private TextBox txtNomeProduto;
        private TextBox txtQuant;
        private Button btnAdicionarEstoque;
        private Button btnRemoveEstoque;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Panel panel5;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Button btnCadastroEstoque;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox5;
        private Button button2;
        private Button btnEditarEstoque;
    }
}