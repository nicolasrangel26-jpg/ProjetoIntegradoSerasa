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
    public partial class EditarClientes : Form
    {
        int ClienteId;
        string conexao = "Server=localhost; Database=pizzaria; Uid=root; Pwd=;";
        public EditarClientes(int id, string nome, string endereco, int cpf, int telefone)
        {
            InitializeComponent();

            ClienteId = id;
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            txtCPF.Text = cpf.ToString();
            txtTelefone.Text = telefone.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();

                string sql = "UPDATE clientes SET nome=@nome, endereco=@endereco, cpf=@cpf, telefone=@telefone WHERE id_cliente=@id_cliente;";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@cpf", int.Parse(txtCPF.Text));
                cmd.Parameters.AddWithValue("@telefone", int.Parse(txtTelefone.Text));
                cmd.Parameters.AddWithValue("@id_cliente", ClienteId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Cliente atualizado");
            this.Close();
        }
    }
}
