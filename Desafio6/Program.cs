// See https://aka.ms/new-console-template for more information

float a, b;
float soma, subtracao, multiplicacao, divisao;
Console.WriteLine("Digite o primeiro número: ");
a = float.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o segundo número: ");
b = float.Parse(Console.ReadLine()!);
soma = a + b;
subtracao = a - b;
multiplicacao = a * b;
divisao = a / b;
Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);
Console.ReadKey();

