
Console.WriteLine("Digi// See https://aka.ms/new-console-template for more informationte a nota média do aluno: ");
int notaMedia = int.Parse( Console.ReadLine()!);
if (notaMedia >= 5)
{
    Console.WriteLine("Aprovado");
}
else if (notaMedia < 5)
{
    Console.WriteLine("Reprovado");
}
else
{
    Console.WriteLine("Nota inválida");
}