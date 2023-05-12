//crie uma classe chamada Produto
//crie as propriedades: Codigo, Nome, Preco
//crie um construtor vazio de classes
//crie um construtor com todos os atributos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploList
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Construtor vazio
        public Produto()
        {
            
        }

        // Construtor com todos os atributos
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }

}


