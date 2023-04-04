// See https://aka.ms/new-console-template for more information

//! Estruturas de repetição 

int i = 1;

while (i <= 10)
{
    Console.WriteLine(i);
    i = i + 2;
    i++;

}


bool idadeCerta = false;

while (idadeCerta == false) //* (!(idadeCerta == true))
{
    Console.WriteLine($"Qual a idade do CR7?");
    int idade = int.Parse(Console.ReadLine()!);

    if (idade == 38)
    {
        idadeCerta = true;
    }

}

Console.WriteLine($"Informe o nome do usuário: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Informe a senha do usuário: ");
string senha = Console.ReadLine()!;

while (senha.Length != 6)
{
    Console.WriteLine($"Informe a senha novamente, tem que ter 6 caracteres.");
    senha = Console.ReadLine()!;

}

Console.WriteLine($"Usuário e senha recebidos com sucesso!");

do 
{
    Console.WriteLine($"Qual a idade do CR7?");
    int idade = int.Parse(Console.ReadLine()!);

    if (idade == 38)
    {
        idadeCerta = true;
    }

} while (idadeCerta == false);

