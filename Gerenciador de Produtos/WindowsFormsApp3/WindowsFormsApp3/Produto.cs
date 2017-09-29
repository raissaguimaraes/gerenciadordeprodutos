using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Produto
    {
        private int idProduto;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        private string nomeProduto;

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        private int codigoProduto;

        public int CodigoProduto
        {
            get { return codigoProduto; }
            set { codigoProduto = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Produto(string nomeProduto, int codigoProduto, string tipo)
        {
            this.nomeProduto = nomeProduto;
            this.codigoProduto = codigoProduto;
            this.tipo = tipo;
        }

        public Produto(int idProduto, string nomeProduto, int codigoProduto, string tipo) : this(nomeProduto, codigoProduto, tipo)
        {
            this.idProduto = idProduto;
        }

        public Produto() { }
    }
}
