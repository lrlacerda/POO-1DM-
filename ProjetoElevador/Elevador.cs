using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoElevador
{
    public class Elevador
    {

        public int andarAtual { get; set; }
        public int totalAndares { get; set; }
        public int capacidade { get; set; }
        public int pessoasPresentes { get; set; }


        public Elevador(int capacidade, int totalAndares)
        {
            this.andarAtual = 0; // elevador começa no térreo
            this.totalAndares = 10;
            this.capacidade = 5;
            this.pessoasPresentes = 0; // elevador começa vazio
        }

        public void Entrar()
        {
            if (pessoasPresentes < capacidade)
            {
                Console.WriteLine("Uma pessoa entrou no elevador.");

                pessoasPresentes++;

                Console.WriteLine("Pessoas no elevador: " + pessoasPresentes);
                
            }
            else
            {
                Console.WriteLine($"Entrada não permitida, limite máximo de pessoas!");
            }
        }

        public void Sair()
        {
            if (pessoasPresentes > capacidade)
            {
                pessoasPresentes--;
            }
        }

        public void Subir()
        {
            if (andarAtual <= totalAndares)
            {
                Console.WriteLine("O elevador subiu para o andar.");

                andarAtual++;

                Console.WriteLine("Andar: " + andarAtual);
            }
            else
            {
                Console.WriteLine($"Ultimo andar!");
            }

        }

        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
            }
        }
    }

}
