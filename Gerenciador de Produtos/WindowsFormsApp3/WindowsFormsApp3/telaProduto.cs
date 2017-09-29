using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp3
{
    public partial class telaProduto : Form
    {
        public telaProduto()
        {
            InitializeComponent();
        }

        private void telaProduto_Load(object sender, EventArgs e)
        {  
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Raissa\Projetos de Desenvolvimento\Gerenciador de Produtos\WindowsFormsApp3\WindowsFormsApp3\DB.mdb";
            string incluirSQL = "INSERT INTO Produtos(nomeProduto,codigoProduto,tipoProduto)values(@nomeProduto,@codigoProduto,@tipoProduto)";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@nomeProduto", OleDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@codigoProduto", OleDbType.VarChar).Value = txtCodigo.Text;
            comando.Parameters.Add("@tipoProduto", OleDbType.VarChar).Value = txtTipoProduto.Text;

            try
            {
                obterConexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obterConexao.Close();
            }
        }
    }
}
