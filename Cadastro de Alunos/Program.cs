// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

using Cadastro_de_Alunos;

Aluno aluno = new Aluno();


Console.Write("Digite o nome do aluno:");
aluno.Nome = Console.ReadLine();

Console.Write("Digite o curso do aluno:");
aluno.Curso = Console.ReadLine();

Console.Write("Digite a idade do aluno:");
aluno.Idade = int.Parse(Console.ReadLine());

Console.Write("Digite o RG do aluno:");
aluno.RG = Console.ReadLine();

Console.Write("O aluno é bolsista? (true/false)");
aluno.Bolsista = bool.Parse(Console.ReadLine().ToLower());

Console.Write("Digite a média final do aluno:");
aluno.MediaFinal = double.Parse(Console.ReadLine());

Console.Write("Digite o valor da mensalidade:");
aluno.ValorMensalidade = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha uma das opções abaixo:");
Console.WriteLine("1 - Ver média final");
Console.WriteLine("2 - Ver valor da mensalidade");

int opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    aluno.VerMediaFinal();
}
else if (opcao == 2)
{
    aluno.VerMensalidade();
}
else
{
    Console.WriteLine("Opção inválida.");
}


    


















    

    