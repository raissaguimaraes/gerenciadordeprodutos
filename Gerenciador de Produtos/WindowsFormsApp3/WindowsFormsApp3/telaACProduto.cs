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
    public partial class telaACProduto : Form
    {
        string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Raissa\Desktop\DB.mdb";

        public telaACProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string incluirSQL = "SELECT * FROM Produtos WHERE codigoProduto=@codigoProduto";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@codigoProduto", OleDbType.VarChar).Value = txtPesquisar.Text;
            try
            {

                if (txtPesquisar.Text == "")
                {
                    throw new Exception("Digite um Codigo para pesquisar o produto!");
                }

                obterConexao.Open();
                OleDbDataReader cs = comando.ExecuteReader();
                if (cs.HasRows == false)
                {
                    throw new Exception("Codigo não cadastrado!");
                }
                else
                {
                    cs.Read();
                    txtNome.Text = Convert.ToString(cs["nomeProduto"]);
                    txtCodigo.Text = Convert.ToString(cs["codigoProduto"]);
                    txtTipoProduto.Text = Convert.ToString(cs["tipoProduto"]);
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

        private void telaACProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            string com = "UPDATE Produtos SET nomeProduto=@nomeProduto,codigoProduto=@codigoProduto,tipoProduto=@tipoProduto WHERE codigoProduto=@codigoProduto";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(com, obterConexao);

            comando.Parameters.Add("@nomeProduto", OleDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@codigoProduto", OleDbType.VarChar).Value = txtCodigo.Text;
            comando.Parameters.Add("@tipoProduto", OleDbType.VarChar).Value = txtTipoProduto.Text;

            try
            {
                obterConexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Alterados!");
            }
            catch(Exception ex)
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

            if (MessageBox.Show("Você realmente deseja excluir este produto?",
                  "ATENÇÃO!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
            else
            {
                string com = "DELETE FROM Produtos WHERE codigoProduto=@codigoProduto ";

                OleDbConnection obterConexao = new OleDbConnection(stringConexao);
                OleDbCommand comando = new OleDbCommand(com, obterConexao);

                comando.Parameters.Add("@codigoProduto", OleDbType.VarChar).Value = txtCodigo.Text;

                try
                {
                    obterConexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("O produto foi excluído!");
                }
                catch(Exception ex)
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
            txtNome.Clear();
            txtCodigo.Clear();
            txtPesquisar.Clear();
            txtTipoProduto.Clear();
        }
    }
}
