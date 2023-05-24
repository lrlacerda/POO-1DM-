using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Console.Model;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        //método para exibir a lista de produtos
        public void Listar(List<Produto> produto)
        {

             Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:c}");
            }

        }
    }
}