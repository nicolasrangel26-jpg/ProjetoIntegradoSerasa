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

            MySqlConnection con = new MySqlConnection(conexao);

            InitializeComponent();

            string sql = "SELECT * FROM clientes";


            MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();

            banco.Fill(dt);
            dgvClientes.DataSource = dt;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();

                string sql = "insert into clientes (Nome,CPF, Endereço, Telefone) values (@Nome, @CPF, @Endereço,@Telefone) ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Endereço", txtEndereço.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado");
            }
            catch (Exception ex) { }
            try
            {
                string sql = "SELECT * FROM clientes";


                MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                dgvClientes.DataSource = dt;
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { }



        }

        private void txtEndereço_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idSelecionado = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id_cliente"].Value);

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sqldelete = "DELETE FROM clientes WHERE id_cliente = @id_cliente";
                MySqlCommand cmd = new MySqlCommand(sqldelete, con);
                cmd.Parameters.AddWithValue("@id_cliente", idSelecionado);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string sql = "SELECT * FROM clientes";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                dgvClientes.DataSource = dt;
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
