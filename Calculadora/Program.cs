using Calculadora;

CalculadoraPoo CalculadoraPoo = new CalculadoraPoo();

Console.WriteLine($"********Programa Calculadora*********");


Console.Write($"\nDigite o {1}º número: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write($"\nDigite o {2}º  número: ");
float num2 = float.Parse(Console.ReadLine());

Console.Write($"Digite a operação desejada (+, -, *, /): ");
char operacao = char.Parse(Console.ReadLine());

float resultado = 0;
switch (operacao)
{
    case '+':
        resultado = CalculadoraPoo.Adicionar(num1, num2);
        Console.WriteLine($"\nAdição: {resultado}");
        break;
    case '-':
        resultado = CalculadoraPoo.Subtrair(num1, num2);
        Console.WriteLine($"\nSubtração: {resultado}");
        break;
    case '*':
        resultado = CalculadoraPoo.Multiplicar(num1, num2);
        Console.WriteLine($"\nMultiplicação: {resultado}");
        break;
    case '/':
        {
            resultado = CalculadoraPoo.Dividir(num1, num2);
            Console.WriteLine($"\nDivisão: {resultado}");
        }
        break;
    default:
        {
            Console.WriteLine($"Caracter incorreto");
        }
        break;
}

Console.ReadKey();












