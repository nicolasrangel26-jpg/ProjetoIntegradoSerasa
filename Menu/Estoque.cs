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
        string conexao = "Server=localhost; Database=pizzaria; Uid=root; Pwd=;";
        public Estoque()
        {
            InitializeComponent();
        }

        public void CarregarEstoque()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "SELECT * FROM estoque";
                MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                dgvTabelaEstoque.DataSource = dt;
                dgvTabelaEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTabelaEstoque.ClearSelection();
            }
            catch { }
        }

        private void btnEncoEstoque_Click(object sender, EventArgs e)
        {
            Encomanda telaEnco = new Encomanda();
            telaEnco.Show();
            this.Close();
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
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

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                    string.IsNullOrWhiteSpace(txtQuant.Text))
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
                string sql = "INSERT INTO estoque (produto, quant, validade) VALUES (@produto,@quant,@validade)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@produto", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@quant", txtQuant.Text);
                cmd.Parameters.AddWithValue("@validade", dateTimePicker2.Value);

                cmd.ExecuteNonQuery();
                txtNomeProduto.Clear();
                txtQuant.Clear();

                CarregarEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveEstoque_Click(object sender, EventArgs e)
        {
            if (dgvTabelaEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a linha de um produto",
                "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int idSelecionado = Convert.ToInt32(dgvTabelaEstoque.CurrentRow.Cells["id_produto"].Value);

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sqldelete = "DELETE FROM estoque WHERE id_produto = @id_produto";
                MySqlCommand cmd = new MySqlCommand(sqldelete, con);
                cmd.Parameters.AddWithValue("@id_produto", idSelecionado);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso");

                CarregarEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnEditarEstoque_Click(object sender, EventArgs e)
        {
            if (dgvTabelaEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a linha de um produto",
                "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvTabelaEstoque.CurrentRow.Cells["id_produto"].Value);
            string produto = dgvTabelaEstoque.CurrentRow.Cells["produto"].Value.ToString();
            int quant = Convert.ToInt32(dgvTabelaEstoque.CurrentRow.Cells["quant"].Value);
            DateTime validade = Convert.ToDateTime(dgvTabelaEstoque.CurrentRow.Cells["validade"].Value);

            EditarEstoque frm = new EditarEstoque(id, produto, quant, validade);
            frm.ShowDialog();
            CarregarEstoque();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            CarregarEstoque();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
