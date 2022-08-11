using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEmp.banco;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace PEmp.Forms
{
    public partial class estoque : Form
    {
        public void consulta()
        {

            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM cadastro_prod", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvProduto.DataSource = ds;
                dgvProduto.DataMember = ds.Tables[0].TableName;
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
        public void incluir()
        {

            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {

                string sql = "INSERT INTO cadastro_prod(id, nomeproduto, quantidade, valorproduto) VALUES (@id, @nomeproduto, @quantidade, @valorproduto)";
                //cria um objeto do tipo comando passando como parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere dados da textbox no comando sql
                c.Parameters.Add(new SqlParameter("@id", this.txtCod.Text));
                c.Parameters.Add(new SqlParameter("@nomeproduto", this.txtValor.Text));
                c.Parameters.Add(new SqlParameter("@quantidade", this.txtQtd.Text));
                c.Parameters.Add(new SqlParameter("@valorproduto", this.txtValor.Text));
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


        public estoque()
        {
            InitializeComponent();
            consulta();
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            incluir();
            consulta();
        }


        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
           Program.Intnum(e);
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.floatnum(sender, e);
        }

        private void txtquantidade_Leave(object sender, EventArgs e)
        {
            var num = Convert.ToDecimal(txtval.Text);
            txtval.Text = num.ToString("N2");
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            var valor = Convert.ToDecimal(txtval.Text);
            var quantidade = Convert.ToInt32(txtQtd.Text);
            valor = quantidade * valor;
            lblValorT.Text=valor.ToString("N2");
        }
    }
}
