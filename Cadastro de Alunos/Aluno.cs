using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_Alunos
{
    public class Aluno
    {
        public string Nome;
        public string Curso;
        public int Idade;
        public string RG;
        public bool Bolsista;
        public double MediaFinal;
        public double ValorMensalidade;


        public void VerMediaFinal()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("A média final do aluno " + Nome + " é " + MediaFinal);
            Console.ResetColor();
        }

        public void VerMensalidade()
        {
            if (Bolsista && MediaFinal >= 8)
            {
                ValorMensalidade = 0.5 * ValorMensalidade;
            }
            else if (Bolsista && MediaFinal > 6 && MediaFinal < 8)
            {
                ValorMensalidade = 0.3 * ValorMensalidade;
            }
            else
            {
                ValorMensalidade = ValorMensalidade;
            }
            Console.WriteLine("O valor da mensalidade do aluno " + Nome + " é R$ " + ValorMensalidade);
        }

    }

}