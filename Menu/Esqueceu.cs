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
    public partial class Esqueceu : Form
    {
        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=;";
        public Esqueceu()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            string nome = txtUsuario.Text;
            string novaSenha = txtNovaSenha.Text;

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                try
                {
                    con.Open();

                    // Verifica se usuário existe
                    string checkSql = "SELECT COUNT(*) FROM logoin WHERE nome = @nome";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@nome", nome);

                    int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        // Atualiza senha
                        string updateSql = "UPDATE logoin SET senha = @senha WHERE nome = @nome";
                        MySqlCommand cmd = new MySqlCommand(updateSql, con);

                        cmd.Parameters.AddWithValue("@senha", novaSenha);
                        cmd.Parameters.AddWithValue("@nome", nome);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Senha alterada com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
