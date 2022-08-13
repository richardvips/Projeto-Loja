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

                SqlCommand cmd = new SqlCommand("SELECT * FROM cadastro_produto", conn);
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



        public estoque()
        {
            InitializeComponent();
            consulta();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            arquString.incluirDdProduto(txtCod.Text, txtNome.Text, txtval.Text, txtQtd.Text);
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

            txtQtd_Leave(sender, e);
        }

        public void txtQtd_Leave(object sender, EventArgs e)
        {
            if (txtval.Text != String.Empty && txtQtd.Text != String.Empty)
            {

                var valor = Convert.ToDecimal(txtval.Text);
                var quantidade = Convert.ToInt32(txtQtd.Text);
                valor = quantidade * valor;
                lblValorT.Text = valor.ToString("N2");
            }
        }

        private void estoque_Load(object sender, EventArgs e)
        {

        }
    }
}
