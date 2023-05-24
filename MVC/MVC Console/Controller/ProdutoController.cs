using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Console.Model;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        //instanciar o objeto Produto e Produtoview
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProduto()
        {
            //lista de produtos chamada pela Model
            List<Produto> produtos = produto.Ler();

            //chamada do método de exibição (View) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }
    }
}