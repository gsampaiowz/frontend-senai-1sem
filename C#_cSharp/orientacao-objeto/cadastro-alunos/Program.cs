﻿using cadastro_alunos;

Aluno aluno = new Aluno();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@$"
--------------------
Cadastro de alunos
--------------------");

Console.WriteLine($"\nDigite o nome do aluno: ");
aluno.nome = Console.ReadLine()!;

Console.WriteLine($"\nDigite o curso do aluno: ");
aluno.curso = Console.ReadLine()!;

Console.WriteLine($"\nDigite a idade do aluno: ");
aluno.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nDigite o RG do aluno: ");
aluno.rg = Console.ReadLine()!;

Console.WriteLine($"\nO aluno é bolsista? s/n");
string validarBolsa = Console.ReadLine()!.ToLower();

if (validarBolsa == "s") { aluno.bolsista = true; } else { aluno.bolsista = false; }

Console.WriteLine($"\nDigite a média final do aluno: ");
aluno.mediaFinal = float.Parse(Console.ReadLine()!);
Console.WriteLine($"\nDigite o valor da mensalidade do aluno: ");
aluno.valorMensalidade = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"
MENU
[1] - Visualizar a média
[2] - Visualizar a mensalidade
[0] - Sair da aplicação");
string opcao = Console.ReadLine()!;

switch (opcao)
{
    case "1":
        aluno.VerMediaFinal();
        break;
    case "2":
        aluno.VerMensalidade();
        break;
    case "0":
        Console.WriteLine($"/nEncerrando...");
        Thread.Sleep(2000);
        Console.WriteLine($"/nAplicação encerrada.");
        break;
    default:
        Console.WriteLine($"\nOpção inválida!");
        break;
}

