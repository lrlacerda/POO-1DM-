using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeProdutos
{
    public class Login
    {
        private bool logado;
        private Usuario usuarioLogado;

        public Login()
        {
            logado = false;
            usuarioLogado = null;
            if (!logado)
            {
                Console.WriteLine("Nenhum usuário está logado!");
                return;
            }
            else
            {
                logado = false;
                Console.WriteLine("Logout realizado com sucesso!");
            }
        }

    }
}