using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using static PEmp.Forms.loja;

namespace PEmp.banco
{
    public class arquString
    {
        public static void incluircompra(string nome_cliente, string cpf_cliente, string cod_produto, string quantidade, string data_compra, string valorprod)
        {
            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {

                string sql = "INSERT INTO compras(nome_cliente, cpf_cliente, cod_produto, quantidade_produto, data_compra, valor) VALUES (@nome_cliente, @cpf_cliente, @cod_produto, @quantidade_produto, @data_compra, @valor)";
                string sqlc2= ""
                //cria um objeto do tipo comando passando como parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);


                var valor_total_produto = Convert.ToDecimal(valorprod.ToString(CultureInfo.InvariantCulture));
                int quantidade_produto = Convert.ToInt32(quantidade.ToString(CultureInfo.InvariantCulture));


                //Insere dados da textbox no comando sql

                c.Parameters.Add(new SqlParameter("@nome_cliente", nome_cliente));
                c.Parameters.Add(new SqlParameter("@cpf_cliente", cpf_cliente));
                c.Parameters.Add(new SqlParameter("@cod_produto", cod_produto));
                c.Parameters.Add(new SqlParameter("@quantidade_produto", quantidade_produto));
                c.Parameters.Add(new SqlParameter("@data_compra", data_compra));
                c.Parameters.Add(new SqlParameter("@valor", valor_total_produto));

                conn.Open();
                //abrir a conexao
                //executa  comando sql no banco
                c.ExecuteNonQuery();
                conn.Close();
                string registrocompra = ("\r Produto: "+cod_produto+"\r Quantidade: "+quantidade+"\r valor: "+ valor_total_produto+"\r");

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


                    MessageBox.Show("Compra realizada com Sucesso");




            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro:" + ex);
            }
            finally
            {
                conn.Close();
            }


        }




        public static void incluirCadastroCliente(string cpf, string nome, string data_nac, string email, string telefone_1, string telefone_2)
        {
            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {

                string sql = "INSERT INTO cadastro_cliente(cpf, nome, data_nac, email, telefone_1, telefone_2) VALUES (@cpf, @nome, @data_nac, @email, @telefone_1, @telefone_2)";
                //cria um objeto do tipo comando passando como parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere dados da textbox no comando sql

                c.Parameters.Add(new SqlParameter("@cpf", cpf));
                c.Parameters.Add(new SqlParameter("@nome", nome));
                c.Parameters.Add(new SqlParameter("@data_nac", data_nac));
                c.Parameters.Add(new SqlParameter("@email", email));
                c.Parameters.Add(new SqlParameter("@telefone_1", telefone_1));
                c.Parameters.Add(new SqlParameter("@telefone_2", telefone_2));
                conn.Open();
                //abrir a conexao
                //executa  comando sql no banco
                c.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastrado com Sucesso");




            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro:" + ex);
            }
            finally
            {
                conn.Close();
            }


        }

        public static void incluirDdProduto(string txtCod, string txtnome, string txtvalor,string txtquantidade)
        {
            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {

                string sql = "INSERT INTO cadastro_produto(cod_produto, nomeproduto, quantidade, valor_produto) VALUES (@cod_produto, @nomeproduto, @quantidade, @valor_produto)";
                //cria um objeto do tipo comando passando como parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere dados da textbox no comando sql

                decimal convertfloat = Convert.ToDecimal(txtvalor.ToString(CultureInfo.InvariantCulture));
                int convertint = Convert.ToInt32(txtquantidade.ToString(CultureInfo.InvariantCulture));

                c.Parameters.Add(new SqlParameter("@cod_produto", txtCod));
                c.Parameters.Add(new SqlParameter("@nomeproduto", txtnome));
                c.Parameters.Add(new SqlParameter("@quantidade", convertint));
                c.Parameters.Add(new SqlParameter("@valor_produto", convertfloat));
                conn.Open();
                //abrir a conexao
                //executa  comando sql no banco
                c.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastrado com Sucesso");




            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro:" + ex);
            }
            finally
            {
                conn.Close();
            }



        }

        public static string procurararquivo()
        {
            if (File.Exists(@"db\db.txt"))
            {
                //procura o arquivoTXT gerado
                string[] lerC = File.ReadAllLines(@"db\db.txt");
                //armazena a  linha do arquivo do diretorio connection string
                string caminho = lerC[0];
                //altera a extenção para interpretar a udl
                string novocaminho = caminho.Remove(caminho.Length - 3, 3) + "udl";
                string caminhoPath = Path.ChangeExtension(caminho, ".txt");
                try { 
                //procura e le o arquivoTXT gerado
                string[] ler = File.ReadAllLines(novocaminho);
                //armazena a 3 linha do arquivo para conexão
                string valor_db = ler[2];
                //separa o texto a cada ";" e armazena em um array
                char[] delimiterChars = { ';' };
                string[] words = valor_db.Split(delimiterChars);
                string armazena = "";
                int i = 0;
                //armazena na variavel "armazena" do segundo ponto do ";" em diante, formando o connection string 
                foreach (var word in words)
                {
                    if (i >= 1)
                        armazena = armazena + word + ";";
                    i++;
                }
                return armazena;
                }
                catch
                {
                    MessageBox.Show("Erro ao selecionar arquivo de banco");
                    return "";
                }


            }
            else
            {
                MessageBox.Show("Erro no diretorio do banco");

                return "";
            }
            }

        public static void connOpen()
        {
           
                string connetionString = arquString.procurararquivo();
                SqlConnection conn = new SqlConnection(connetionString);
                try
                {
                    conn.Open();

                }
                catch
                {
                    MessageBox.Show("Conexão Falhou");

                }
                finally
                {
                    conn.Close();
                }

            
        }
        public static void connClose()
        {

            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {
                conn.Open();

            }
            catch
            {
                MessageBox.Show("Conexão Falhou");

            }
            finally
            {
                conn.Close();
            }


        }




    }
    }

