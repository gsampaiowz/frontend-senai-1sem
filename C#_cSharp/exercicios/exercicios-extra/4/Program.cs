﻿// See https://aka.ms/new-console-template for more information
/* 
*Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
*"Telefonou para a vítima?"
*"Esteve no local do crime?"
*"Mora perto da vítima?"
*"Devia para a vítima?"
*"Já trabalhou com a vítima?"
*O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.
*/

int respostaSIM = 0;

Console.WriteLine($"\n PERGUNTAS SOBRE O CRIME: ");

Console.WriteLine($"\n Telefonou para a vítima? S ou N");
char resposta = char.Parse(Console.ReadLine()!.ToUpper());

if (resposta == 'S')
{
    respostaSIM++;
}
else if (resposta != 'N')
{
    Console.WriteLine($"Favor responder com S ou N!");
    resposta = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"\n Esteve no local do crime? S ou N");
resposta = char.Parse(Console.ReadLine()!.ToUpper());

if (resposta == 'S')
{
    respostaSIM++;
}
else if (resposta != 'N')
{
    Console.WriteLine($"Favor responder com S ou N!");
    resposta = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"\n Mora perto da vítima? S ou N");
resposta = char.Parse(Console.ReadLine()!.ToUpper());

if (resposta == 'S')
{
    respostaSIM++;
}
else if (resposta != 'N')
{
    Console.WriteLine($"Favor responder com S ou N!");
    resposta = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"\n Devia para a vítima? S ou N");
resposta = char.Parse(Console.ReadLine()!.ToUpper());

if (resposta == 'S')
{
    respostaSIM++;
}
else if (resposta != 'N')
{
    Console.WriteLine($"Favor responder com S ou N!");
    resposta = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"\n Já trabalhou com a vítima? S ou N");
resposta = char.Parse(Console.ReadLine()!.ToUpper());

if (resposta == 'S')
{
    respostaSIM++;
}
else if (resposta != 'N')
{
    Console.WriteLine($"Favor responder com S ou N!");
    resposta = char.Parse(Console.ReadLine()!.ToUpper());
}

cwl