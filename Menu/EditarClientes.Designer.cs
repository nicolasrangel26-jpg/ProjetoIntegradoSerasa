namespace Menu
{
    partial class EditarClientes
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
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(381, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(430, 27);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(381, 23);
            txtEndereco.TabIndex = 1;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 89);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(281, 23);
            txtCPF.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(360, 89);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(281, 23);
            txtTelefone.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(703, 83);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 29);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 6;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(31, 16);
            label3.TabIndex = 7;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 71);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 8;
            label4.Text = "Telefone";
            // 
            // EditarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(823, 125);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Name = "EditarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}