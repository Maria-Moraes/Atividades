using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Digite um número positivo: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada do {num}");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
};

Console.ReadKey();