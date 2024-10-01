int numero;
do
{
    Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
} 
while (numero != 7);
{
    Console.WriteLine($"Você acertou o número secreto");
}

Console.ReadLine();