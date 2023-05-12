using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Cor { get; set; }

        // Construtor vazio
        public Carro()
        {

        }

        // Construtor completo
        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }

    }

}
