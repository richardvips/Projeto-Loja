using PEmp.Forms;
using System.IO;
using PEmp.banco;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PEmp
{
    public partial class Form1 : Form
    {
        public void connstri()
        {   
            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {
                conn.Open();
                lblconn.Text ="ATIVO";
                lblconn.ForeColor = Color.Green;
                conn.Close();

            }
            catch
            {
                lblconn.Text = "Desativado";
                lblconn.ForeColor = Color.Red;
                MessageBox.Show("Conexão Falhou"); 

            }
            finally
            {
                conn.Close();
            }
        }
        public Form1()
        {

            InitializeComponent();
            connstri();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //chama o form estoque
           estoque btnEstoque = new estoque();
            btnEstoque.ShowDialog();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            loja btnLoja = new loja();
            btnLoja.ShowDialog();

        }





        private void btnBanco_Click(object sender, EventArgs e)
        {   
            //cria um arquivo de procura para deixar a udl setada como padrao

            // ENCONTRAR ARQUIVO UDL
            this.ofdBanco.Multiselect = false;
            ofdBanco.InitialDirectory = "c:\\";
            this.ofdBanco.Title = "Bucar arquivo UDL";
            ofdBanco.RestoreDirectory = true;
            if (ofdBanco.ShowDialog() == DialogResult.OK)
            {
                //armazena o diretorio do arquivo
               string caminho = ofdBanco.FileName;
                //verifica se existe e salva o caminho para um txt
                if(File.Exists(@"db\db.txt"))
                {
                    using (StreamWriter sw = new StreamWriter(@"db\db.txt"))
                    {
                        sw.WriteLine(caminho);
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"db");
                    using (StreamWriter sw = new StreamWriter(@"db\db.txt"))
                    { 
                    sw.WriteLine(caminho);
                    }
                }
            }
            try { 
            connstri();
            }
            catch
            {
                MessageBox.Show("Verifique os arquivos e tente novamente.");
            }
        }


    }
}