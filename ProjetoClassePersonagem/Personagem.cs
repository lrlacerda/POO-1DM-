using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClassePersonagem
{
    public class Personagem
    {

        //declarar as propriedades
        public string nome = "Tony Stark";
        public int idade = 35;
        public string armadura = "Bleeding Edge";
        public string ia = "Jarvis";


        //Declarar o método
        public void Atacar()
        {
            Console.WriteLine($"O Personagem Atacou");
            
        }

        public string Defender()
        {
            return "O Personagem Defendeu";
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O Personagem arrumou a Armadura");
            
        }


    }


}