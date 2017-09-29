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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            telaProduto telaCadProd = new telaProduto();
            telaCadProd.ShowDialog();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            telaACProduto telaACProd = new telaACProduto();
            telaACProd.ShowDialog();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            telaFornecedor telaCadFor= new telaFornecedor();
            telaCadFor.ShowDialog();
        }

        private void btnEditFornecedor_Click(object sender, EventArgs e)
        {
            telaACFornecedor telaACFor = new telaACFornecedor();
            telaACFor.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            telaRelatorio telaRelatorio = new telaRelatorio();
            telaRelatorio.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
