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
            this.totalAndares = totalAndares;
            this.capacidade = capacidade;
            this.pessoasPresentes = 0; // elevador começa vazio
        }

        public void Entrar()
        {
            if (pessoasPresentes < capacidade)
            {
                pessoasPresentes++;
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
            if (andarAtual < totalAndares)
            {
                andarAtual++;
            }
        }

        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
            }
        }


        public int GetAndarAtual()
        {
            return andarAtual;
        }

        public int GetTotalAndares()
        {
            return totalAndares;
        }

        public int GetCapacidade()
        {
            return capacidade;
        }

        public int GetPessoasPresentes()
        {
            return pessoasPresentes;
        }

        public void SetAndarAtual(int andarAtual)
        {
            this.andarAtual = andarAtual;
        }

        public void SetTotalAndares(int totalAndares)
        {
            this.totalAndares = totalAndares;
        }

        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public void SetPessoasPresentes(int pessoasPresentes)
        {
            this.pessoasPresentes = pessoasPresentes;
        }
    }

}
