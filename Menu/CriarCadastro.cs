using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
    

namespace Menu
{
    public partial class CriarCadastro : Form
    {
        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=;";
        public CriarCadastro()
        {
            InitializeComponent();
        }

        private void btnSCadastro_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string senha = txtSenha.Text;




            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO logoin (nome, senha) VALUES (@nome, @senha)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void chksenha_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chksenha.Checked)
            {

                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
           
        }
    }
}

