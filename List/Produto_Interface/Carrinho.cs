using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public double Valor { get; set; }

        //lista onde vamos manipular os objetos
        List<Produto> carrinho = new List<Produto>();

        //implementar a lógica para cada método

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Listar()
        {
            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($"Código: {p.Codigo} Nome: {p.Nome} Preço: R$ {p.Preco}");

                }
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio!");

            }
        }

        public void Atualizar(int codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = produto.Preco;
        }

        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void ValorTotal()
        {
            Valor = 0;

            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"O total do seu carrinho está em: {Valor:C}");
            }
            else
            {
                Console.WriteLine($"Seu carrinho está vazio!");
                
            }
        }
    }
}
