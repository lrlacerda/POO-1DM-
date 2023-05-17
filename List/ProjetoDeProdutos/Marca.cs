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

        List<Marca> listaDeMarcas = new List<Marca>();

        public Marca Cadastrar()
        {

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;

            listaDeMarcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar()
        {
            Console.WriteLine("=== LISTA DE MARCAS ===");
            foreach (var marca in listaDeMarcas)
            {
                Console.WriteLine($"Código: {marca.Codigo}");
                Console.WriteLine($"Nome: {marca.NomeMarca}");
                Console.WriteLine($"Data de Cadastro: {marca.DataCadastro}");
                Console.WriteLine("=======================");
            }
        }

        public void Deletar(int codigo)
        {
            Marca marca = listaDeMarcas.FirstOrDefault(m => m.Codigo == codigo);

            if (marca != null)
            {
                listaDeMarcas.Remove(marca);
                Console.WriteLine("Marca removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Marca não encontrada!");
            }
        }
    }

}