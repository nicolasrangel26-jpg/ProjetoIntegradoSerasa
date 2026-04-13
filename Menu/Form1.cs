namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEstoqueMenu_Click(object sender, EventArgs e)
        {
            Estoque telaEestoque = new Estoque();
            telaEestoque.Show();
            this.Hide();
        }

        private void btnEncoMenu_Click(object sender, EventArgs e)
        {
            Encomanda telaEnco = new Encomanda();
            telaEnco.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
    }
}
