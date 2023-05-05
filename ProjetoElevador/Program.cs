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

Elevador elevador = new Elevador(8, 10);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"*****Sistema Elevador*****");
Console.ResetColor();


Console.WriteLine($"Andar atual: {elevador.GetAndarAtual()}");
Console.WriteLine($"Total de andares: {elevador.GetTotalAndares()}");
Console.WriteLine($"Capacidade: {elevador.GetCapacidade()}");
Console.WriteLine($"Pessoas presentes: {elevador.GetPessoasPresentes()}");

Console.WriteLine("\nEntrando duas pessoas:");
elevador.Entrar();
elevador.Entrar();

Console.WriteLine($"Pessoas presentes: {elevador.GetPessoasPresentes()}");

Console.WriteLine("\nDigite o andar desejado:");
int andarDesejado = int.Parse(Console.ReadLine());

if (andarDesejado > elevador.GetAndarAtual())
{
    for (int i = 0; i < andarDesejado - elevador.GetAndarAtual(); i++)
    {
        elevador.Subir();
    }
}
else if (andarDesejado < elevador.GetAndarAtual())
{
    for (int i = 0; i < elevador.GetAndarAtual() - andarDesejado; i++)
    {
        elevador.Descer();
    }
}

Console.WriteLine($"Andar atual: {elevador.GetAndarAtual()}");

Console.WriteLine("\nAdicionando mais pessoas:");
elevador.Entrar();
elevador.Entrar();
elevador.Entrar();
elevador.Entrar();

Console.WriteLine($"Pessoas presentes: {elevador.GetPessoasPresentes()}");

Console.WriteLine("\nTentando adicionar mais pessoas:");
elevador.Entrar();
elevador.Entrar();

Console.WriteLine($"Pessoas presentes: {elevador.GetPessoasPresentes()}");

Console.WriteLine("\nSaindo duas pessoas:");
elevador.Sair();
elevador.Sair();

Console.WriteLine($"Pessoas presentes: {elevador.GetPessoasPresentes()}");

Console.WriteLine("\nMudando o andar atual:");
elevador.SetAndarAtual(5);

Console.WriteLine($"Andar atual: {elevador.GetAndarAtual()}");











