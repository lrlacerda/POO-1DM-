using System;
using System.Globalization;
using Exercicio_1;

ConversorMoedas.ConverterDolarParaReal(5.0);
ConversorMoedas.ConverterRealParaDolar(5.0);

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("===== Conversor de Moedas =====");
Console.WriteLine("1. Dólar para Real");
Console.WriteLine("2. Real para Dólar");
Console.WriteLine("3. Sair");
Console.WriteLine("===============================");
Console.ResetColor();


bool sair = false;

while (!sair)
{
    Console.Write("Selecione uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o valor em dólar: ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorReal = ConversorMoedas.ConverterDolarParaReal(valorDolar);
            Console.WriteLine("Valor em Real: " + valorReal.ToString("C", CultureInfo.CurrentCulture));
            break;

        case 2:
            Console.Write("Digite o valor em Real: ");
            double valorReal2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorDolar2 = ConversorMoedas.ConverterRealParaDolar(valorReal2);
            Console.WriteLine("Valor em Dólar: " + valorDolar2.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            break;

        case 3:
            sair = true;
            Console.WriteLine("Programa encerrado.");
            break;

        default:
        Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
            Console.ResetColor();
            break;
    }

    Console.ReadLine();
}

