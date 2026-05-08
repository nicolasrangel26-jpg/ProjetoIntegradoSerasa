using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Menu
{

    public partial class Login : Form


    {

        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=;";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string nome = txtLogin.Text;
            string senha = txtSenha.Text;




            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT COUNT(*) FROM logoin WHERE nome = @nome AND Senha = @senha";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.ExecuteNonQuery();
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    if (resultado > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CriarCadastro criarCadastro = new CriarCadastro();
            criarCadastro.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {

            if (chkSenha.Checked)
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



