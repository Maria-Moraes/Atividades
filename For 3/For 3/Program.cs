int numero;

Console.WriteLine("Digite um número inteiro positivo: ");
while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
{
    Console.WriteLine("Número inválido. Digite um número unteiro positivo: ");
}

Console.WriteLine($"Os números ímpares de 0 até {numero} são: ");

for (int i = 1; i < numero; i += 2)
{
        Console.WriteLine(i);
}

Console.ReadKey();