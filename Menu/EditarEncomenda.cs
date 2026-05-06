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
            cbbSabooor.Text =Sabores;
            nudEdtQuantSabor.Text = QP.ToString();
            cbbBebidas2.Text = Bebida;
            nudEdtQuantBebida.Text = QB.ToString();
            txtEdtObs.Text = OBS;
        }

        private void btnEditarEnco_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbBebidas2.Text) ||
                   string.IsNullOrWhiteSpace(cbbClientes.Text) ||
                     string.IsNullOrWhiteSpace(cbbSabooor.Text)  ||
                         string.IsNullOrWhiteSpace(nudEdtQuantBebida.Text) ||
                            string.IsNullOrWhiteSpace(txtEdtObs.Text)||
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

                string sql = "UPDATE pedidos SET id_pizza=@id_pizza, quant_pizza=@quant_pizza, id_Bebidas=@id_Bebidas, Quant_Bebida=@quant_bebida, Obs=@Obs, id_Clientes=@id_Clientes WHERE id_pedido=@id_pedido;";
                
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id_pizza", cbbSabooor.SelectedValue);
                cmd.Parameters.AddWithValue("@quant_pizza", nudEdtQuantSabor.Text);
                cmd.Parameters.AddWithValue("@id_bebidas", cbbBebidas2.SelectedValue);
                cmd.Parameters.AddWithValue("@Quant_Bebida", nudEdtQuantBebida.Text);
                cmd.Parameters.AddWithValue("@Obs", txtEdtObs.Text);
                cmd.Parameters.AddWithValue("@id_Clientes", cbbClientes.SelectedValue);
                cmd.Parameters.AddWithValue("@Obs", txtEdtObs.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Produto atualizado");
            this.Close();
        }
    }
    
}
