double tempCelsius;
double mult = 0;
double soma = 0;

Console.WriteLine("Informe a temperatura em Celsius: ");
tempCelsius = Convert.ToInt16(Console.ReadLine());

mult = (tempCelsius * 1.8);

soma = (mult + 32);

Console.WriteLine($"A temperatura em Fahrenheit é {soma}");