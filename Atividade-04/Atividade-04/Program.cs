double pi = 3.14;
double area = 0;
double raio;
double raio2 = 0;

Console.Write("Informe um raio para um círculo: ");
raio = Convert.ToDouble(Console.ReadLine());

raio2 = raio * raio;
area = pi * raio2;
Console.WriteLine($"O valor do círculo é {raio}, do PI é {pi} e a área é {area}.");