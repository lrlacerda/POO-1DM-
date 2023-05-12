using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }


        public Produto()
        {
            
        }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

    }
}