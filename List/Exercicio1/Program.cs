//Criar uma classe "carro"
//propriedades: string marca, string cor

//criar construtor vazio e um completo

//cadastrar e inserir em uma lista 2 objetos (dinâmicos)
//entrada de dados pelo console

//exibir os dados dos objetos no console (foreach)

using Exercicio1;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine("Informe os dados do carro {0}:", i + 1);

    Console.Write("Marca: ");
    carro.Marca = Console.ReadLine();

    Console.Write("Cor: ");
    carro.Cor = Console.ReadLine();

    carros.Add(carro);
}

Console.WriteLine("\nDados dos carros cadastrados:");

foreach (Carro carro in carros)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Marca: {0}, Cor: {1}", carro.Marca, carro.Cor);
    Console.ResetColor();
}

