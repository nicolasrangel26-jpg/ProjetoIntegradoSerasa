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
    public partial class EditarEstoque : Form
    {
        int ProdutoId;
        string conexao = "Server=localhost; Database=pizzaria; Uid=root; Pwd=;";
        public EditarEstoque(int id, string produto, int quant, DateTime validade)
        {
            InitializeComponent();

            ProdutoId = id;
            txtProdutoEditar.Text = produto;
            txtQuantEditar.Text = quant.ToString();
            dateTimePicker1.Value = validade;
        }

        private void btnSalvarEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();

                string sql = "UPDATE estorque SET produto=@produto, quant=@quant, validade=@validade WHERE id_produto=@id_produto;";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@produto", txtProdutoEditar.Text);
                cmd.Parameters.AddWithValue("@quant", txtQuantEditar.Text);
                cmd.Parameters.AddWithValue("@validade", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@id_produto", ProdutoId);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Produto atualizado");
            this.Close();
        }
    }
}
