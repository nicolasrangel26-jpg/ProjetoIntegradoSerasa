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

        public void CarregarClientes()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "SELECT * FROM clientes";
                MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                dgvClientes.DataSource = dt;
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClientes.ClearSelection();

                dgvClientes.EnableHeadersVisualStyles = false;
                dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 0, 0);
                dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Impact", 12, FontStyle.Italic);

            }
            catch { }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarClientes();
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
            DialogResult resultado = MessageBox.Show(
                    "Deseja realmente fechar o aplicativo?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtEndereço.Text) ||
                    string.IsNullOrWhiteSpace(txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show(
                    "Preencha todas as informações!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();

                string sql = "insert into clientes (Nome, CPF, Endereco, Telefone) values (@Nome, @CPF, @Endereco, @Telefone) ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Endereco", txtEndereço.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado");

                txtNome.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtEndereço.Clear();

                CarregarClientes();
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

            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a linha de um cliente",
                            "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

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

                CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a linha de um cliente",
                "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id_cliente"].Value);
            string nome = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
            string endereco = dgvClientes.CurrentRow.Cells["endereco"].Value.ToString();
            int cpf = Convert.ToInt32(dgvClientes.CurrentRow.Cells["cpf"].Value.ToString());
            int telefone = Convert.ToInt32(dgvClientes.CurrentRow.Cells["telefone"].Value.ToString());

            EditarClientes frm = new EditarClientes(id, nome, endereco, cpf, telefone);
            frm.ShowDialog();
            CarregarClientes();
        }
    }
}
