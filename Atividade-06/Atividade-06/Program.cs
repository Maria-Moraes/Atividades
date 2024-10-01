double salariomensal;
double percentualaum;
double divisao = 0;
double mult = 0;
double soma = 0;

Console.Write("Informe seu salário mensal: ");
salariomensal = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o percentual de aumento: ");
percentualaum = Convert.ToInt16(Console.ReadLine());

divisao = percentualaum / 100;

mult = divisao * salariomensal;

soma = mult + salariomensal;

Console.WriteLine($"O novo salário será {soma}");