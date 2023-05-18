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
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }

        List<Produto> listaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.Write("Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.Now;

            Console.Write("Digite o código da marca do produto:");
            int codigoMarca = int.Parse(Console.ReadLine());
            novoProduto.Marca = Marca.ListaDeMarcas.FirstOrDefault(m => m.Codigo == codigoMarca);

            Console.Write("Digite o código do usuário que cadastrou o produto: ");
            int codigoUsuario = int.Parse(Console.ReadLine());
            novoProduto.CadastradoPor = Usuario.ListaUsuarios.FirstOrDefault(u => u.Codigo == codigoUsuario);

            listaDeProdutos.Add(novoProduto);
        }

        public void Listar()
        {
            Console.WriteLine("=== LISTA DE PRODUTOS ===");
            foreach (var produto in listaDeProdutos)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Código: {produto.Codigo}");
                Console.WriteLine($"Nome: {produto.NomeProduto}");
                Console.WriteLine($"Preço: R${produto.Preco}");
                Console.WriteLine($"Data de Cadastro: {produto.DataCadastro}");
                Console.WriteLine($"Marca: {produto.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {produto.CadastradoPor.Nome}");
                Console.WriteLine("=========================");
                Console.ResetColor();
            }
        }

        public void Deletar(int codigo)
        {
            Produto produto = listaDeProdutos.FirstOrDefault(p => p.Codigo == codigo);

            if (produto != null)
            {
                listaDeProdutos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

    }
}