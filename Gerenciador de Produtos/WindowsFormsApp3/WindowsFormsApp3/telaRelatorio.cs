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
    public partial class telaRelatorio : Form
    {
        string stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Raissa\Projetos de Desenvolvimento\Gerenciador de Produtos\WindowsFormsApp3\WindowsFormsApp3\DB.mdb";

        public telaRelatorio()
        {
            InitializeComponent();
        }

        private void btnIncluirStatus_Click(object sender, EventArgs e)
        {
            string incluirSQL = "INSERT INTO Status(nomeFornecedor,nomeProduto,data,status)values(@nomeFornecedor,@nomeProduto,@data,@status)";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@nomeFornecedor", OleDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@nomeProduto", OleDbType.VarChar).Value = txtCodigo.Text;
            comando.Parameters.Add("@data", OleDbType.VarChar).Value = txtData.Text;
            comando.Parameters.Add("@status", OleDbType.VarChar).Value = txtStatus.Text;

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

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnAlterarRe_Click(object sender, EventArgs e)
        {
            string com = "UPDATE Status SET nomeFornecedor=@nomeFornecedor,nomeProduto=@nomeProduto,data=@data,status=@status WHERE idStatus=@idStatus";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(com, obterConexao);

            comando.Parameters.Add("@nomeFornecedor", OleDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@nomeProduto", OleDbType.VarChar).Value = txtCodigo.Text;
            comando.Parameters.Add("@data", OleDbType.VarChar).Value = txtData.Text;
            comando.Parameters.Add("@status", OleDbType.VarChar).Value = txtStatus.Text;
            comando.Parameters.Add("@idstatus", OleDbType.VarChar).Value = txtPesquisar.Text;

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

        private void btnExibir_Click(object sender, EventArgs e)
        {
            OleDbConnection obterConexao = new OleDbConnection(stringConexao);

            obterConexao.Open();
            OleDbCommand cmd = obterConexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Status";
            cmd.ExecuteNonQuery();
            DataTable bd = new DataTable();
            OleDbDataAdapter bdt = new OleDbDataAdapter(cmd);
            bdt.Fill(bd);
            dataGridView.DataSource = bd;
            obterConexao.Close();
        }

        private void btnDeletarRe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir este relatório?",
                  "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada!");
            }
            else
            {
                string com = "DELETE FROM Status WHERE idStatus=@idStatus ";

                OleDbConnection obterConexao = new OleDbConnection(stringConexao);
                OleDbCommand comando = new OleDbCommand(com, obterConexao);

                comando.Parameters.Add("@idStatus", OleDbType.VarChar).Value = txtPesquisar.Text;

                try
                {
                    obterConexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("O relatório foi excluído!");
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

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            string incluirSQL = "SELECT * FROM Status WHERE idStatus=@idStatus";

            OleDbConnection obterConexao = new OleDbConnection(stringConexao);
            OleDbCommand comando = new OleDbCommand(incluirSQL, obterConexao);

            comando.Parameters.Add("@idStatus", OleDbType.VarChar).Value = txtPesquisar.Text;
            try
            {

                if (txtPesquisar.Text == "")
                {
                    throw new Exception("Digite o id do Status para consultar o relatório!");
                }

                obterConexao.Open();
                OleDbDataReader cs = comando.ExecuteReader();
                if (cs.HasRows == false)
                {
                    throw new Exception("Não existe relatório para data informada!");
                }
                else
                {
                    cs.Read();
                    txtNome.Text = Convert.ToString(cs["nomeFornecedor"]);
                    txtCodigo.Text = Convert.ToString(cs["nomeProduto"]);
                    txtData.Text = Convert.ToString(cs["data"]);
                    txtStatus.Text = Convert.ToString(cs["status"]);
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

        private void telaRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtData.Clear();
            txtStatus.Clear();
            txtPesquisar.Clear();
        }
    }
}
