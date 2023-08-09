namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // botão Excluir
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                int index = dataGridView1.CurrentCell.RowIndex; // remove o index da tabela
                produtos.RemoveAt(index);


                dataGridView1.DataSource = null; // zera os elementos
                dataGridView1.Refresh(); // Atualizar toda a tabela
                dataGridView1.DataSource = produtos; // e logo joga os novos elementos na tebela

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ops, ocorreu um erro!{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato inválido");
            }

        }

        private void button1_Click(object sender, EventArgs e) // Botão Novo
        {




            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Cadrastrar
        {
            try
            {
                Produto produto = new Produto();
                produto.Codigo = textBox1.Text;
                produto.Descricao = textBox4.Text;

                produto.ValorAqui = Convert.ToInt32(textBox2.Text);
                produto.Lucro = Convert.ToInt32(textBox5.Text);
                produto.ValordaVenda = produto.ValorAqui + (produto.ValorAqui * produto.Lucro / 100);
                textBox3.Text = produto.ValordaVenda.ToString();
                produtos.Add(produto);


                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, ocorreu um erro!");
            }
            finally
            {

            }


        }
    }
}