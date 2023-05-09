using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public static class ConversorMoedas
    {
        private static double taxaCambio = 5.0; 

        public static double ConverterDolarParaReal(double valorDolar)
        {
            return valorDolar * taxaCambio;
        }

        public static double ConverterRealParaDolar(double valorReal)
        {
            return valorReal / taxaCambio;
        }

    }
}