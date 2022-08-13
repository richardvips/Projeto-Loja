using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEmp.banco;
using PEmp.Pagamento;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PEmp.Forms
{
    public partial class loja : Form
    {
        public void arqcarregar2()
        {
            String registrocompra = ("\r--------------------------\r Data da compra: " + lblData.Text+"\r\r Cliente: " + txtNome.Text +"\r CPF: "+txtCpf.Text +"\r \r");
            if (File.Exists(@"historico\his.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"historico\his.txt", true, Encoding.ASCII))
                {

                    sw.Write(registrocompra);

                }
            }
            else
            {
                Directory.CreateDirectory(@"historico");
                using (StreamWriter sw = new StreamWriter(@"historico\his.txt", true, Encoding.ASCII))
                {

                    sw.Write(registrocompra);

                }
            }
        }
        public void arqcarregar1()
        {
            String registrocompra = ("\r\r Valor total: R$ " + lblTotal.Text +"\r Pagamento: "+ cbPagamento.Text + "\r --------------------------\r");
            if (File.Exists(@"historico\his.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"historico\his.txt", true, Encoding.ASCII))
                {

                    sw.Write(registrocompra);

                }
            }
            else
            {
                Directory.CreateDirectory(@"historico");
                using (StreamWriter sw = new StreamWriter(@"historico\his.txt", true, Encoding.ASCII))
                {

                    sw.Write(registrocompra);

                }
            }
        }
        public void carregar()
        {
            txtCpf.Text = clientes.cadastro[0]; 
            txtNome.Text = clientes.cadastro[1]; 
            txtData.Text = clientes.cadastro[2]; 
            txtEmail.Text = clientes.cadastro[3]; 
            txtTel1.Text = clientes.cadastro[4]; 
            txtTel2.Text = clientes.cadastro[5]; 
        }

        public loja()
        {
            InitializeComponent();
            carregar();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string cpf=txtCpf.Text; string nome = txtNome.Text; string data_nac = txtData.Text; string email = txtEmail.Text; string telefone1=txtTel1.Text; string telefone2 = txtTel2.Text;
            
            arquString.incluirCadastroCliente(cpf, nome, data_nac, email, telefone1, telefone2);
        }

        public void loja_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd'/'MM'/'yyyy");

            string [] pagamento = new string[2];
            pagamento[0] = "Dinheiro";
            pagamento[1] = "Cartão";
            cbPagamento.DataSource = pagamento;

           
            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {

                conn.Open();
            string codprodutos = @"
                    SELECT  
                        cod_produto,
                        nomeproduto,
                        quantidade, 
                        valor_produto

                    FROM
                        cadastro_produto
                    ORDER BY cod_produto
                ";

                SqlDataAdapter cmd = new SqlDataAdapter(codprodutos, conn);
                DataTable dtResult = new DataTable();
                cmd.Fill(dtResult);

                cb_codProduto.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_codProduto.DataSource = null;
                cb_codProduto.DataSource = dtResult;
                cb_codProduto.DisplayMember = "cod_produto";
                cb_codProduto.Text = "";





                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro na consulta:" + ex);
            }
            finally
            {
                conn.Close();
            }



        }

        private void cb_codProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verifica se foi seleccionado um item na lista
            if (cb_codProduto.SelectedIndex != -1)
            {

                //Podemos obter o linha seleccionada com a propriedade SeletedItem                 
                DataRowView drw = ((DataRowView)cb_codProduto.SelectedItem);
                txtNomeProd.Text = drw["nomeproduto"].ToString();
                lblValorProduto.Text = drw["valor_produto"].ToString();
                lblQtdEstoque.Text = drw["quantidade"].ToString();
                var num = Convert.ToDecimal(lblValorProduto.Text);
                lblValorProduto.Text = num.ToString("N2");
                int val = Convert.ToInt32(drw["quantidade"].ToString());
                txtQtd.Minimum = 1;
                txtQtd.Maximum = val;
            }
            else
            {
                txtNomeProd.Text = "";
                lblValorProduto.Text = "";
                lblQtdEstoque.Text = "";
            }
        }
        public static void ThreadProc()
        {
            //coloca o form em uma Thread e fecha a anterior
            Application.Run(new clientes());
        }
        private void button1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToDecimal(lblValorProduto.Text);
            var quantidade = Convert.ToInt32(txtQtd.Text);
            valor = quantidade * valor;
            string total = valor.ToString("N2");

            List <carrinho> carrrinho = new List<carrinho> {
            new carrinho { cpf = txtCpf.Text, codProduto = txtNomeProd.Text, quantidade =quantidade.ToString(), valor = total }
                };
            //Mudei a visualização para detalhes para cada item aparecer em coluna...

            lvCarrinho.View = View.Details;

            //Percorre a lista adicionando as linhas do ListView
            foreach (var item in carrrinho)
            {
                lvCarrinho.Items.Add(new ListViewItem(new string[] { item.cpf, item.codProduto, item.quantidade,item.valor }));
            }
            valorTotal();
            btnFinalizar.Enabled = true;
        }
        public class carrinho
        {
            public string cpf { get; set; }
            public string codProduto { get; set; }
            public string quantidade { get; set; }
            public string  valor { get; set; }
        }
        
        private void lvCarrinho_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lvCarrinho.Items.RemoveAt(lvCarrinho.SelectedIndices[0]);
            valorTotal();
        }

        private void valorTotal()
        {
            var valorTotal = 0m;
            for (int i = 0; i < lvCarrinho.Items.Count; i++)
            {
                valorTotal += decimal.Parse(lvCarrinho.Items[i].SubItems[3].Text);
            }
            lblTotal.Text = valorTotal.ToString("N2");
        }




        private void banco()
        {
            var valor2 = 0m;
            string nome_cliente; string cpf_cliente; string cod_produto; string quantidade_produto; string data_compra; string Valor;
            for (int i = 0; i < lvCarrinho.Items.Count; i++)
            {
                nome_cliente = txtNome.Text;
                cpf_cliente = lvCarrinho.Items[i].SubItems[0].Text;
                cod_produto = lvCarrinho.Items[i].SubItems[1].Text;
                quantidade_produto = lvCarrinho.Items[i].SubItems[2].Text;
                Valor =lvCarrinho.Items[i].SubItems[3].Text;
                valor2 = decimal.Parse(Valor);
                Valor = valor2.ToString("N2");
                data_compra = lblData.Text;
                arquString.incluircompra( nome_cliente,  cpf_cliente,  cod_produto,  quantidade_produto,  data_compra, Valor);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            arqcarregar2();
            banco();
            arqcarregar1();

           
        }
    }
}
