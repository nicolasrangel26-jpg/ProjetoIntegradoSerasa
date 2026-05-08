namespace Menu
{
    partial class CriarCadastro
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
            btnSCadastro = new Button();
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtSenha = new TextBox();
            chksenha = new CheckBox();
            SuspendLayout();
            // 
            // btnSCadastro
            // 
            btnSCadastro.Location = new Point(140, 158);
            btnSCadastro.Name = "btnSCadastro";
            btnSCadastro.Size = new Size(75, 23);
            btnSCadastro.TabIndex = 0;
            btnSCadastro.Text = "Salvar";
            btnSCadastro.UseVisualStyleBackColor = true;
            btnSCadastro.Click += btnSCadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 111);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario ";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(128, 85);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(128, 129);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // chksenha
            // 
            chksenha.AutoSize = true;
            chksenha.Location = new Point(209, 134);
            chksenha.Name = "chksenha";
            chksenha.Size = new Size(15, 14);
            chksenha.TabIndex = 5;
            chksenha.UseVisualStyleBackColor = true;
            chksenha.CheckedChanged += chksenha_CheckedChanged;
            // 
            // CriarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 229);
            Controls.Add(chksenha);
            Controls.Add(txtSenha);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSCadastro);
            Name = "CriarCadastro";
            Text = "CriarCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSCadastro;
        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtSenha;
        private CheckBox chksenha;
    }
}