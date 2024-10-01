using System.Runtime.Serialization;

int n1, n2;
int soma = 0;
int subtracao = 0;
int mult = 0;
int divisao = 0;

Console.Write("Informe o primeiro número: ");
n1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o segundo número: ");
n2 = Convert.ToInt16(Console.ReadLine());

soma = n1 + n2;
Console.WriteLine($"A soma dos valores é: {soma}");

subtracao = n1 - n2;
Console.WriteLine($"A subtração dos valores é: {subtracao}");

mult = n1 * n2;
Console.WriteLine($"A multiplicação dos valores é: {mult}");

divisao = n1 / n2; 
Console.WriteLine($"A divisão dos valores é: {divisao}");
