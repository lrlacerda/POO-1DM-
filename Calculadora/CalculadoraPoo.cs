using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraPoo
    {
        //declarando os métodos
        public float Adicionar(float a, float b)
        {
            return a + b;
        }

        public float Subtrair(float a, float b)
        {
            return a - b;
        }

        public float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public float Dividir(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine($"\nNão é possível dividir por zero.");
            }

            return a / b;

        }

    }
}








