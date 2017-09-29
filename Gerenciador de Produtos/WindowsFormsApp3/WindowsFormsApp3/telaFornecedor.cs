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
    public partial class telaFornecedor : Form
    {
        public telaFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Raissa\Projetos de Desenvolvimento\Gerenciador de Produtos\WindowsFormsApp3\WindowsFormsApp3\DB.mdb";
            string incluirSQL = "INSERT INTO Fornecedores (nomeFornecedor,cnpjFornecedor,email)values(@nomeFornecedor,@cnpjFornecedor,@email)";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@nomeFornecedor", OleDbType.VarChar).Value = txtNomeFornecedor.Text;
            comando.Parameters.Add("@cnpjFornecedor", OleDbType.VarChar).Value = txtCnpj.Text;
            comando.Parameters.Add("@email", OleDbType.VarChar).Value = txtEmail.Text;

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

        private void telaFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
