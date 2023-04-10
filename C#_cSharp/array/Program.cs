// See https://aka.ms/new-console-template for more information

//* SEM ARRAY

// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"\nDigite o nome do carro: ");
// carro1 = Console.ReadLine()!;
// Console.WriteLine($"\nDigite o nome do carro: ");
// carro2 = Console.ReadLine()!;
// Console.WriteLine($"\nDigite o nome do carro: ");
// carro3 = Console.ReadLine()!;

// Console.WriteLine($"\n{carro1}, {carro2}, {carro3}");

//* COM ARRAY

string[] carros = new string[3];

Console.WriteLine($"\nDigite o nome do carro: ");
carros[0] = Console.ReadLine()!;

Console.WriteLine($"\nPrimeiro carro da lista: {carros[0]}");
Console.WriteLine($"\nSegundo carro da lista: {carros[1]}");
Console.WriteLine($"\nTerceiro carro da lista: {carros[2]}");
