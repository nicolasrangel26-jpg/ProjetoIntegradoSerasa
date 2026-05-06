namespace Menu
{
    partial class EditarEncomenda
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
            btnEditarEnco = new Button();
            txtEdtObs = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbSabooor = new ComboBox();
            label6 = new Label();
            nudEdtQuantSabor = new NumericUpDown();
            nudEdtQuantBebida = new NumericUpDown();
            cbbBebidas2 = new ComboBox();
            cbbClientes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudEdtQuantSabor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEdtQuantBebida).BeginInit();
            SuspendLayout();
            // 
            // btnEditarEnco
            // 
            btnEditarEnco.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEnco.Location = new Point(102, 427);
            btnEditarEnco.Name = "btnEditarEnco";
            btnEditarEnco.Size = new Size(132, 40);
            btnEditarEnco.TabIndex = 0;
            btnEditarEnco.Text = "Salvar";
            btnEditarEnco.UseVisualStyleBackColor = true;
            btnEditarEnco.Click += btnEditarEnco_Click;
            // 
            // txtEdtObs
            // 
            txtEdtObs.Location = new Point(12, 366);
            txtEdtObs.Name = "txtEdtObs";
            txtEdtObs.Size = new Size(300, 23);
            txtEdtObs.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 6;
            label1.Text = "Sabor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 214);
            label2.Name = "label2";
            label2.Size = new Size(172, 18);
            label2.TabIndex = 7;
            label2.Text = "Quantidade (pizza)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 8;
            label3.Text = "Bebida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 280);
            label4.Name = "label4";
            label4.Size = new Size(183, 18);
            label4.TabIndex = 9;
            label4.Text = "Quantidade (bebida)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 348);
            label5.Name = "label5";
            label5.Size = new Size(104, 18);
            label5.TabIndex = 10;
            label5.Text = "Observação";
            // 
            // cbbSabooor
            // 
            cbbSabooor.FormattingEnabled = true;
            cbbSabooor.Location = new Point(12, 41);
            cbbSabooor.Name = "cbbSabooor";
            cbbSabooor.Size = new Size(300, 23);
            cbbSabooor.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 14;
            label6.Text = "Cliente";
            // 
            // nudEdtQuantSabor
            // 
            nudEdtQuantSabor.Location = new Point(12, 235);
            nudEdtQuantSabor.Name = "nudEdtQuantSabor";
            nudEdtQuantSabor.Size = new Size(155, 23);
            nudEdtQuantSabor.TabIndex = 15;
            // 
            // nudEdtQuantBebida
            // 
            nudEdtQuantBebida.Location = new Point(12, 299);
            nudEdtQuantBebida.Name = "nudEdtQuantBebida";
            nudEdtQuantBebida.Size = new Size(155, 23);
            nudEdtQuantBebida.TabIndex = 16;
            // 
            // cbbBebidas2
            // 
            cbbBebidas2.FormattingEnabled = true;
            cbbBebidas2.Location = new Point(12, 110);
            cbbBebidas2.Name = "cbbBebidas2";
            cbbBebidas2.Size = new Size(300, 23);
            cbbBebidas2.TabIndex = 17;
            // 
            // cbbClientes
            // 
            cbbClientes.FormattingEnabled = true;
            cbbClientes.Location = new Point(12, 175);
            cbbClientes.Name = "cbbClientes";
            cbbClientes.Size = new Size(300, 23);
            cbbClientes.TabIndex = 18;
            // 
            // EditarEncomenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 489);
            Controls.Add(cbbClientes);
            Controls.Add(cbbBebidas2);
            Controls.Add(nudEdtQuantBebida);
            Controls.Add(nudEdtQuantSabor);
            Controls.Add(label6);
            Controls.Add(cbbSabooor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEdtObs);
            Controls.Add(btnEditarEnco);
            Name = "EditarEncomenda";
            Text = "EditarEncomenda";
            ((System.ComponentModel.ISupportInitialize)nudEdtQuantSabor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEdtQuantBebida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditarEnco;
        private TextBox txtEdtQntSabor;
        private TextBox txtEdtQntBebida;
        private TextBox txtEdtObs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbbSabooor;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label6;
        private NumericUpDown nudEdtQuantSabor;
        private NumericUpDown nudEdtQuantBebida;
        private ComboBox cbbBebidas2;
        private ComboBox cbbClientes;
    }
}