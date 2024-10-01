double numdecimal;
int numint = 0;

Console.Write("Insira um número decimal: ");
numdecimal = Convert.ToDouble(Console.ReadLine());

numint = Convert.ToInt16(numdecimal);

Console.WriteLine($"O número {numdecimal} foi convertido para um número inteiro que seria {numint}");