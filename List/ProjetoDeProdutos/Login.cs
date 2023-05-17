using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeProdutos
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {     
            Usuario user = new Usuario();

            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        
        public void Logar(Usuario usuario)
        {
            Console.Write($"Insira seu email: ");
            string email = Console.ReadLine();

            Console.Write($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso !");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar!");
            }
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            1 - Cadastrar Produto
            2 - Listar Produtos
            3 - Remover Produto
            ----------------------
            4 - Cadastrar Marca
            5 - Listar Marcas
            6 - Remover Marca
            ----------------------
            0 - Sair
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        produto.Cadastrar();
                        break;
                    case "2":

                        produto.Listar();
                        break;
                    case "3":

                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":

                        marca.Cadastrar();
                        break;
                    case "5":

                        marca.Listar();
                        break;
                    case "6":

                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;
                    case "0":

                        Console.WriteLine($"Programa encerrado !");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (opcao != "0");

        }

    }
}
