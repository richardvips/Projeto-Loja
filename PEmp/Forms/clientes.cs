using PEmp.banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEmp.Forms
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }
        public void consulta()
        {

            string connetionString = arquString.procurararquivo();
            SqlConnection conn = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From cadastro_cliente", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvClientes.DataSource = ds;
                dgvClientes.DataMember = ds.Tables[0].TableName;
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
        private void clientes_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public static void ThreadProc()
        {
            //coloca o form em uma Thread e fecha a anterior
            Application.Run(new loja());
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            cadastro[0] = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            cadastro[1] = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            cadastro[2] = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            cadastro[3] = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            cadastro[4] = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            cadastro[5] = dgvClientes.CurrentRow.Cells[5].Value.ToString();

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
            this.Close();
        }


        public static string[] cadastro = new string[6];
    }
}
