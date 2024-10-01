int nota;
Console.Write("Informa a sua nota: ");
int.TryParse(Console.ReadLine(), out nota);


if ( nota >=90 && nota <=100 )
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O aluno tem nota A");
    Console.ResetColor();
}
else if (nota >=80 && nota <= 89)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O aluno tem nota B");
    Console.ResetColor();
}
else if ( nota >= 70 && nota <= 79)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("O aluno tem nota C");
    Console.ResetColor();
}
else if (nota >= 60 && nota <= 69)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("O aluno tem nota D");
    Console.ResetColor();
}
else if ( nota < 60 && nota > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("O aluno tem nota F");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nota Inválida!");
    Console.ResetColor();
}

    Console.ReadKey();