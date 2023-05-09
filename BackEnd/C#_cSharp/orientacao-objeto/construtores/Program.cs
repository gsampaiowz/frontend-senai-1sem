using construtores;

Produto produto1 = new Produto();

produto1.Codigo = "1234";

Console.WriteLine($"{produto1.Codigo}");

Produto produto2 = new Produto("5678");
