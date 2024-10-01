using System.Globalization;

try
{
    Console.Write("Digite o primeiro número: ");
    double num1;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num1))
    {
        Console.WriteLine("Erro: por favor digite um número válido");
        Console.Write("Digite o primeiro número: ");
    }

    Console.Write("Digite o segundo número: ");
    double num2;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
    {
        Console.WriteLine("Erro: por favor digite um número válido");
        Console.Write("Digite o segundo número: ");
    }

    double soma = num1 + num2;
    Console.WriteLine($"O resultado da soma é: {soma}");

} 
catch(FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}

Console.ReadKey();