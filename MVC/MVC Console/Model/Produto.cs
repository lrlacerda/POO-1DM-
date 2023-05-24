using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Console.Model
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";

        //criar construtor
        public Produto()
        {
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; //Database

            //se não existir uma pasta Database, então cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se não tiver um arquivo csv no caminho, então cria-se um
            if (!File.Exists(PATH))
            {   
                File.Create(PATH);
            }
        }

        //metodo
        public List<Produto> Ler()
        {
            //instanciar uma lista de produtos
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            //para a leitura das linhas
            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                //instanciar um objeto
                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]); //001
                p.Nome = atributos[1]; //Coca
                p.Preco = float.Parse(atributos[2]); //6,50f

                produtos.Add(p);
            }

            return produtos;
        }
    }
}