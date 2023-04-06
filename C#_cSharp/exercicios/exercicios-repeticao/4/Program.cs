// See https://aka.ms/new-console-template for more information

//! INICIO

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine($"\nPesquisa de Mercado:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\nEntrevistando pessoa {i}. Qual seu sexo? Digite F para FEMININO ou M para MASCULINO: ");
    char sexo = char.Parse(Console.ReadLine()!.ToUpper());

    Console.WriteLine($"Agora, você gostou do produto? Digite SIM ou NÃO");
    string produto = Console.ReadLine()!.ToUpper();

    if ()
    {

    }

}

Console.ResetColor();

//! FIM