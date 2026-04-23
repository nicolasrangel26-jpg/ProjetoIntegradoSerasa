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
            MySqlConnection con = new MySqlConnection(conexao);

            InitializeComponent();
            string sql = "SELECT * FROM perdidos";

            MySqlDataAdapter banco = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();

            banco.Fill(dt);
            dgvPedidos.DataSource = dt;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO perdidos (id_cliente,id_pizza,quant_pizza,id_bebida,quant_bebida,obs) VALUES (@id_cliente,@id_pizza,@quant_pizza,@id_bebida,@quant_bebida,@obs)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id_cliente", cbbClientes);
                cmd.Parameters.AddWithValue("@id_pizza", cbbPedidos);
                cmd.Parameters.AddWithValue("@quant_pizza", numericUpDown2);
                cmd.Parameters.AddWithValue("@id_bebida", comboBox3);
                cmd.Parameters.AddWithValue("@quant_bebida", numericUpDown3);
                cmd.Parameters.AddWithValue("@obs", txtObs.Text);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string sql = "SELECT * FROM perdidos";

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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO pizzaz (sabores) values (@sabores)";
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
                string sql = "select * from pizzaz ";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                banco.Fill(dt);

                cbbPedidos.DataSource = dt;
                cbbPedidos.DisplayMember = "sabores";


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
                string sql = "select * from bebidas ";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                banco.Fill(dt);

                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "nome";


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

        private void comboBox2_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
                string sql = "select * from pizzaz ";

                MySqlDataAdapter banco = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                banco.Fill(dt);

                cbbPedidos.DataSource = dt;
                cbbPedidos.DisplayMember = "bebidas";


                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbClientes_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.btnSalvar_Click(sender, e);
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

            }
            catch { }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
