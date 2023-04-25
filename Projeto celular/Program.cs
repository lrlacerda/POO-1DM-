// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Projeto_celular;

Celular celular = new Celular();

Console.WriteLine($"Digite a Cor do celular: ");
celular.cor = Console.ReadLine();

Console.WriteLine($"Digite o Modelo do celular: ");
celular.modelo = Console.ReadLine();

Console.WriteLine($"Digite o Tamanho do celular: ");
celular.tamanho = int.Parse(Console.ReadLine());

Console.WriteLine($"O celular está ligado? s/n");
string ligado = Console.ReadLine().ToLower();

if (ligado == "s")
{
    celular.ligado = true;
}
else if (ligado == "n")
{
    celular.ligado = false;
}
else
{
    Console.WriteLine($"Caracter inválido!");
}

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(@$"


1 - Ligar
2 - Desligar
3 - Fazer Ligação
4 - Mandar Mensagem

");
Console.ResetColor();

string opcao = Console.ReadLine();


switch (opcao)
{
    case value1:
        break;
    default:
        break;
}























    

    