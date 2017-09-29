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
    public partial class telaACFornecedor : Form
    {
        string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Raissa\Projetos de Desenvolvimento\Gerenciador de Produtos\WindowsFormsApp3\WindowsFormsApp3\DB.mdb";

        public telaACFornecedor()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            string com = "UPDATE Fornecedores SET nomeFornecedor=@nomeFornecedor,cnpjFornecedor=@cnpjFornecedor,email=@email WHERE nomeFornecedor=@nomeFornecedor";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(com, obterConexao);

            comando.Parameters.Add("@nomeFornecedor", OleDbType.VarChar).Value = txtNomeFornecedor.Text;
            comando.Parameters.Add("@cnpjFornecedor", OleDbType.VarChar).Value = txtCnpj.Text;
            comando.Parameters.Add("@email", OleDbType.VarChar).Value = txtEmail.Text;

            try
            {
                obterConexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Alterados!");
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string incluirSQL = "SELECT * FROM Fornecedores WHERE nomeFornecedor=@nomeFornecedor";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@nomeFornecedor", OleDbType.VarChar).Value = txtPesquisar.Text;
            try
            {

                if (txtPesquisar.Text == "")
                {
                    throw new Exception("Digite o nome do fornecedor que deseja pesquisar!");
                }

                obterConexao.Open();
                OleDbDataReader cs = comando.ExecuteReader();
                if (cs.HasRows == false)
                {
                    throw new Exception("Nome não cadastrado!");
                }
                else
                {
                    cs.Read();
                    txtNomeFornecedor.Text = Convert.ToString(cs["nomeFornecedor"]);
                    txtCnpj.Text = Convert.ToString(cs["cnpjFornecedor"]);
                    txtEmail.Text = Convert.ToString(cs["Email"]);
                }

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Você realmente deseja excluir este fornecedor?",
                  "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
            else
            {
                string com = "DELETE FROM Fornecedores WHERE cnpjFornecedor=@cnpjFornecedor ";

                OleDbConnection obterConexao = new OleDbConnection(stringConexao);
                OleDbCommand comando = new OleDbCommand(com, obterConexao);

                comando.Parameters.Add("@cnpjFornecedor", OleDbType.VarChar).Value = txtCnpj.Text;

                try
                {
                    obterConexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("O fornecedor foi excluído!");
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCnpj.Clear();
            txtEmail.Clear();
            txtNomeFornecedor.Clear();
            txtPesquisar.Clear();
        }

        private void telaACFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
