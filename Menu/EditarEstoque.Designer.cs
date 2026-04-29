namespace Menu
{
    partial class EditarEstoque
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
            txtProdutoEditar = new TextBox();
            txtQuantEditar = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalvarEditar = new Button();
            SuspendLayout();
            // 
            // txtProdutoEditar
            // 
            txtProdutoEditar.Location = new Point(12, 27);
            txtProdutoEditar.Name = "txtProdutoEditar";
            txtProdutoEditar.Size = new Size(231, 23);
            txtProdutoEditar.TabIndex = 0;
            // 
            // txtQuantEditar
            // 
            txtQuantEditar.Location = new Point(268, 27);
            txtQuantEditar.Name = "txtQuantEditar";
            txtQuantEditar.Size = new Size(124, 23);
            txtQuantEditar.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 3;
            label1.Text = "NOME DO PRODUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "QTD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "VALIDADE";
            // 
            // btnSalvarEditar
            // 
            btnSalvarEditar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarEditar.Location = new Point(268, 72);
            btnSalvarEditar.Name = "btnSalvarEditar";
            btnSalvarEditar.Size = new Size(101, 30);
            btnSalvarEditar.TabIndex = 6;
            btnSalvarEditar.Text = "SALVAR";
            btnSalvarEditar.UseVisualStyleBackColor = true;
            btnSalvarEditar.Click += btnSalvarEditar_Click;
            // 
            // EditarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 114);
            Controls.Add(btnSalvarEditar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtQuantEditar);
            Controls.Add(txtProdutoEditar);
            Name = "EditarEstoque";
            Text = "EditarEstoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProdutoEditar;
        private TextBox txtQuantEditar;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalvarEditar;
    }
}