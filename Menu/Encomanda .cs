using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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
    public partial class Encomanda : Form
    {
        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=;";
        public Encomanda()
        {
            InitializeComponent();
        }

        public void CarregarPedidos()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "SELECT * FROM pedidos";
                MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                dgvPedidos.DataSource = dt;
                dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
            this.Close();
        }

        private void BtnMenuEnco_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {


                conn.Open();



            }
            catch (Exception ex) { }
        }

        private void btnConfirmarPed_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(cbbClientes.SelectedValue);
            int idSabor = Convert.ToInt32(cbbPedidos.SelectedValue);
            int idBebida = Convert.ToInt32(comboBox3.SelectedValue);

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO pedidos (id_cliente, id_pizza, quant_pizza, id_bebida, quant_bebida, obs) VALUES (@id_cliente, @id_pizza, @quant_pizza, @id_bebida, @quant_bebida, @obs)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                cmd.Parameters.AddWithValue("@id_pizza", idSabor);
                cmd.Parameters.AddWithValue("@quant_pizza", numericUpDown2.Value);
                cmd.Parameters.AddWithValue("@id_bebida", idBebida);
                cmd.Parameters.AddWithValue("@quant_bebida", numericUpDown3.Value);
                cmd.Parameters.AddWithValue("@obs", txtObs.Text);

                MessageBox.Show("Pedido salvo");

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string sql = "SELECT clientes.nome, pizzas.sabores, pedidos.quant_pizza, bebidas.nome, pedidos.quant_bebida, pedidos.obs From pedidos INNER JOIN clientes ON pedidos.id_cliente = clientes.id_cliente INNER JOIN pizzas ON pedidos.id_pizza = pizzas.id_pizza INNER JOIN bebidas ON pedidos.id_bebida = bebidas.id_bebida";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                dgvPedidos.DataSource = dt;
                dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Encomanda_Load(object sender, EventArgs e)
        {
            CarregarPedidos();

            MySqlConnection conn = new MySqlConnection(conexao);
            try 
            {
                conn.Open();

                string sql = "SELECT * FROM clientes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbbClientes.DataSource = dt;
                cbbClientes.DisplayMember = "Nome";
                cbbClientes.ValueMember = "id_cliente";


                string sqlPizzas = "SELECT * FROM pizzas";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlPizzas, conn);

                DataTable dt2 = new DataTable();
                adp.Fill(dt2);

                cbbPedidos.DataSource = dt2;
                cbbPedidos.DisplayMember = "sabores";
                cbbPedidos.ValueMember = "id_pizza";


                string sqlBebidas = "SELECT * FROM bebidas";
                MySqlDataAdapter adp2 = new MySqlDataAdapter(sqlBebidas, conn);

                DataTable dt3 = new DataTable();
                adp2.Fill(dt3);

                comboBox3.DataSource = dt3;
                comboBox3.DisplayMember = "nome";
                comboBox3.ValueMember = "id_bebida";
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovoSabor.Text))
            {
                MessageBox.Show(
                    "Preencha o novo sabor!",
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
                string sql = "INSERT INTO pizzas (sabores) values (@sabores)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@sabores", txtNovoSabor.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo sabor registrado");

                txtNovoSabor.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbPedidos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbPedidos_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void cbbPedidos_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
                string sql = "select * from pizzas ";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                banco.Fill(dt);

                cbbPedidos.DataSource = dt;
                cbbPedidos.DisplayMember = "sabores";
                cbbPedidos.ValueMember = "id_pizza";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarObs_Click(object sender, EventArgs e)
        {



        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
                string sql = "select * from bebidas";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                banco.Fill(dt);

                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "nome";
                comboBox3.ValueMember = "id_bebida";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cbbClientes_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM clientes";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                banco.Fill(dt);
                cbbClientes.DataSource = dt;
                cbbClientes.DisplayMember = "Nome";
                cbbClientes.ValueMember = "id_cliente";

                conn.Close();

            }
            catch { }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_Click(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovaBebida.Text))
            {
                MessageBox.Show(
                    "Preencha a nova bebida!",
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
                string sql = "INSERT INTO bebidas (nome) values (@nome)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNovaBebida.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Nova bebida registrada");

                txtNovoSabor.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
