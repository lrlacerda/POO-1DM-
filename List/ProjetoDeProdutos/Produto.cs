using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeProdutos
{
    public class Produto 
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }

        public string Cadastrar()
        {
            return "Produto cadastrado com sucesso!";
        }

        public List<Produto> Listar()
        {
            return new List<Produto>();
        }

        public string Deletar(Produto produto)
        {
            return "Produto deletado com sucesso!";
        }
    }
}