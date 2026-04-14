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
        string conexao = "Server=localhost;Database=encomendas;Uid=root;Pwd=;";
        public Encomanda()
        {
            InitializeComponent();
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
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
                string sql = "select * from pizzaz ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter banco = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                banco.Fill(dt);
                
                cbbPedidos.DataSource = dt;
                cbbPedidos.DisplayMember = "sabores";

                MessageBox.Show("Pedido registrado");
                conn.Close();

            }
            catch (Exception ex) { }

            try
            {
                conn.Open();
                string sql = "select * from "


            } catch (Exception ex) { }


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
                string sql = "insert into pizzaz (sabores) values (@sabores)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@sabores", txtNovoSabor.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo sabor registrado");



             } catch (Exception ex) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
