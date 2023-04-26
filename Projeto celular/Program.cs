// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Projeto_celular;

Celular celular = new Celular();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"***** Bem vindo ao Programa Celular*****");
Console.ResetColor();

Console.Write($"\nDigite a Cor do celular: ");
celular.cor = Console.ReadLine();

Console.Write($"\nDigite o Modelo do celular: ");
celular.modelo = Console.ReadLine();

Console.Write($"\nDigite o Tamanho do celular: ");
celular.tamanho = int.Parse(Console.ReadLine());

Console.Write($"\nO celular está ligado? s/n: ");
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

int opcao;
do
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@$"
1 - Ligar
2 - Desligar
3 - Fazer Ligação
4 - Mandar Mensagem
0 - Sair
");
    Console.ResetColor();

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                celular.Ligar();
            }
            break;
        case 2:
            {
                celular.Desligar();
            }
            break;
        case 3:
            {
                celular.FazerLigacao();
            }
            break;
        case 4:
            {
                celular.EnviarMensagem();
            }
            break;
            case 0:
            {
                Console.WriteLine($"Até Mais!!");
            }
            break;
        default:
            {
                Console.WriteLine($"opção inválida");

            }
            break;
    }
} while (opcao != 0);

























