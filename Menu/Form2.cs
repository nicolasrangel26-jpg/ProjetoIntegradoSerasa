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
    public partial class Form2 : Form
    {
        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEstoqueEnco_Click(object sender, EventArgs e)
        {
            Estoque enco = new Estoque();
            enco.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Encomanda enco = new Encomanda();
            enco.Show();
            this.Close();
        }

        private void BtnMenuEnco_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();

                string sql = "insert into clientes (Nome,CPF, Endereço, Telefone) values (@Nome, @CPF, @Endereço,@Telefone) ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nome" ,txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF" , txtCPF.Text);
                cmd.Parameters.AddWithValue("@Endereço", txtEndereço.Text);
                cmd.Parameters.AddWithValue("@Telefone",txtTelefone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucesso");
            }
            catch (Exception ex) { }



        }
    }
}
