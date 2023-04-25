using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;

     
        public void Ligar()
        {
            if (!this.ligado)
            {
                this.ligado = true;
                Console.WriteLine("O celular foi ligado.");
            }
            else
            {
                Console.WriteLine("O celular já está ligado.");
            }
        }

        public void Desligar()
        {
            if (this.ligado)
            {
                this.ligado = false;
                Console.WriteLine("O celular foi desligado.");
            }
            else
            {
                Console.WriteLine("O celular já está desligado.");
            }
        }

        public void FazerLigacao()
        {
            if (this.ligado)
            {
                Console.WriteLine("Fazendo ligação...");
            }
            else
            {
                Console.WriteLine("Não é possível fazer uma ligação. O celular está desligado.");
            }
        }

        public void EnviarMensagem()
        {
            if (this.ligado)
            {
                Console.WriteLine("Enviando mensagem...");
            }
            else
            {
                Console.WriteLine("Não é possível enviar uma mensagem. O celular está desligado.");
            }
        }
    }

}

