string nome, sobrenome;
Console.Write("Digite seu Nome: ");
nome = Console.ReadLine();
Console.Write("Digite o Sobrenome: ");
sobrenome = Console.ReadLine();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.Write($"Nome completo: {sobrenome.ToUpper()}, {nome}");

