using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeProdutos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public string Cadastrar()
        {
            return "Marca cadastrada com sucesso!";
        }

        public List<Marca> Listar()
        {
            return new List<Marca>();
        }

        public string Deletar(Marca marca)
        {
            return "Marca deletada com sucesso!";
        }
    }
}