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
    public partial class EditarEncomenda : Form
    {
        int PedidoId;
        string conexao = "Server=localhost; Database=pizzaria; Uid=root; Pwd=;";
        public EditarEncomenda(int id, string Nome, string Sabores, int QP, string Bebida, int QB, string OBS)
        {
            InitializeComponent();
            PedidoId = id;
            cbbClientes.Text = Nome;
            cbbSabooor.Text = Sabores;
            nudEdtQuantSabor.Text = QP.ToString();
            cbbBebidas2.Text = Bebida;
            nudEdtQuantBebida.Text = QB.ToString();
            txtEdtObs.Text = OBS;
        }

        private void btnEditarEnco_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbBebidas2.Text) ||
                   string.IsNullOrWhiteSpace(cbbClientes.Text) ||
                     string.IsNullOrWhiteSpace(cbbSabooor.Text) ||
                         string.IsNullOrWhiteSpace(nudEdtQuantBebida.Text) ||
                            string.IsNullOrWhiteSpace(txtEdtObs.Text) ||
                string.IsNullOrWhiteSpace(nudEdtQuantSabor.Text))

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

                string sql = "UPDATE pedidos SET id_pizza=@id_pizza, quant_pizza=@quant_pizza, id_Bebida=@id_Bebida, Quant_Bebida=@quant_bebida, Obs=@Obs, id_Cliente=@id_Cliente WHERE id_pedido=@id_pedido;";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id_pizza", cbbSabooor.SelectedValue);
                cmd.Parameters.AddWithValue("@quant_pizza", nudEdtQuantSabor.Value);
                cmd.Parameters.AddWithValue("@id_Bebida", cbbBebidas2.SelectedValue);
                cmd.Parameters.AddWithValue("@Quant_Bebida", nudEdtQuantBebida.Value);
                cmd.Parameters.AddWithValue("@Obs", txtEdtObs.Text);
                cmd.Parameters.AddWithValue("@id_Cliente", cbbClientes.SelectedValue);
                cmd.Parameters.AddWithValue("@id_pedido", PedidoId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Pedido atualizado");
            this.Close();
        }

        private void EditarEncomenda_Load(object sender, EventArgs e)
        {
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

                cbbSabooor.DataSource = dt2;
                cbbSabooor.DisplayMember = "sabores";
                cbbSabooor.ValueMember = "id_pizza";


                string sqlBebidas = "SELECT * FROM bebidas";
                MySqlDataAdapter adp2 = new MySqlDataAdapter(sqlBebidas, conn);

                DataTable dt3 = new DataTable();
                adp2.Fill(dt3);

                cbbBebidas2.DataSource = dt3;
                cbbBebidas2.DisplayMember = "nome";
                cbbBebidas2.ValueMember = "id_bebida";


            }
            catch { }
        }
    }

}
