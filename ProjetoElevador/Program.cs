// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).


using ProjetoElevador;

Elevador elevador = new Elevador(5, 10);

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"*****Sistema Elevador*****");
Console.ResetColor();

// Loop infinito para simular a utilização do elevador
while (true)
{
    Console.WriteLine("Andar atual: " + elevador.andarAtual);
    Console.WriteLine("Pessoas presentes: " + elevador.pessoasPresentes);

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("\nSelecione uma opção:");
    Console.WriteLine("1 - Entrar");
    Console.WriteLine("2 - Sair");
    Console.WriteLine("3 - Subir");
    Console.WriteLine("4 - Descer");
    Console.ResetColor();

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            elevador.Entrar();
            break;
        case "2":
            elevador.Sair();
            Console.WriteLine("Uma pessoa saiu do elevador.");
            break;
        case "3":
            elevador.Subir();
            break;
        case "4":
            elevador.Descer();
            Console.WriteLine("O elevador desceu para o andar " + elevador.andarAtual + ".");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}


