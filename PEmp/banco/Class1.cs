using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PEmp.banco
{
    public class arquString
    {

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

