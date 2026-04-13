using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Estoque : Form
    {
        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=;";
        public Estoque()
        {
            InitializeComponent();
        }

        private void btnEncoEstoque_Click(object sender, EventArgs e)
        {
            Encomanda telaEnco = new Encomanda();
            telaEnco.Show();
            this.Close();
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO estoque (produto, quant, validade) VALUES (@produto,@quant,@validade)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@produto", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@quant", txtQuant.Text);
                cmd.Parameters.AddWithValue("@validade", txtValidade.Text);

                cmd.ExecuteNonQuery();
                txtNomeProduto.Clear();
                txtQuant.Clear();
                txtValidade.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("sucesso :D");
            }
        }

        private void btnAttEstoque_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                //select procura e seleciona todos
                string sql = "SELECT * FROM estoque";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                // DAtaAdapter sera a ponte para visualizar
                MySqlDataAdapter banco = new MySqlDataAdapter(cmd);

                //Criando uma tabela na memorira C#
                DataTable dt = new DataTable();
                banco.Fill(dt);
                //exibr no gridview
                dgvTabelaEstoque.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void btnRemoveEstoque_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastroEstoque_Click(object sender, EventArgs e)
        {
            Form2 telaCadastro = new Form2();
            telaCadastro.Show();
            this.Close();
        }
    }
}
