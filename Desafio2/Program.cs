// See https://aka.ms/new-console-template for more information
int notaMedia = 8;
if(notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}
else
{
    Console.WriteLine("Reprovado");
}
List<string> linguagens = [ "C#", "Java", "JavaScript" ];
Console.WriteLine("Hello, World!");

Console.WriteLine(linguagens[0]);

Console.WriteLine("Qual o número do grupo das palavras?");   
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(linguagens[num]);
