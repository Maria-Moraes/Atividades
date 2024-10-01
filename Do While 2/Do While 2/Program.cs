int numero;
int num1;
int num2;
do
{
    Console.WriteLine("Opções de Menu");
    Console.WriteLine("1.Exibir uma mensagem");
    Console.WriteLine("2.Fazer uma soma");
    Console.WriteLine("3.Sair");

    Console.WriteLine("Escolha uma opção: ");
    numero = int.Parse(Console.ReadLine());

    if (numero == 1)
    {
        Console.WriteLine("Bem Vindo!");
    }
    else if (numero == 2)
    {
        Console.WriteLine("Você escolheu a opção fazer uma soma!");
        Console.WriteLine("Insira um número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira um número: ");
        num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;
        Console.WriteLine($"A soma dos números é {soma}");
    }
    else if (numero == 3)
    {
        Console.WriteLine("Você escolheu a opção sair!");
    }
    else
    {
        Console.WriteLine("Opção Inválida!");
    }

} while (numero != 3);

Console.ReadLine();