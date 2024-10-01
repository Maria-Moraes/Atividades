string nome;
string sobrenome;
string areas;

Console.Write("Informe o seu nome: ");
nome = Console.ReadLine();

Console.Write("Informe o seu sobrenome: ");
sobrenome = Console.ReadLine();

Console.Write("Informe qual áreas de programação mais te interessa: ");
areas = Console.ReadLine();

Console.WriteLine($"Seu nome completo é: {nome} {sobrenome} e a área de programação que mais te interessa é {areas} ");