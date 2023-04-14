// See https://aka.ms/new-console-template for more information
/*
* Um posto está vendendo combustíveis com a seguinte tabela de descontos:
*Álcool:
*. até 20 litros, desconto de 3% por litro Álcool
*. acima de 20 litros, desconto de 5% por litro
*Gasolina:
*. até 20 litros, desconto de 4% por litro Gasolina
*. acima de 20 litros, desconto de 6% por litro
*
*Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
*da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
*sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
*Dica: utilize switch case e funções/métodos para otimizar o algorítimo.
*/

//! V2

float valor = 0;
float valorDescontado = 0;
float desconto = 0;
float precoAlcool = 4.90F;
float precoGasolina = 5.30F;

static float CalculoAlcool(float litros, float desconto)
{

    if (litros > 0 && litros <= 20)
    {
        return (float)3 / 100;
    }
    else if (litros > 20)
    {
        return (float)5 / 100;
    }
    return desconto;
}

static float CalculoGasolina(float litros, float desconto)
{

    if (litros > 0 && litros <= 20)
    {
        return (float)4 / 100;
    }
    else if (litros > 20)
    {
        return (float)6 / 100;
    }
    return desconto;
}

Console.WriteLine($"\nPOSTO SAMPAIO");

Console.WriteLine($"\nEscolha o tipo de combustível: \nDigite 'A' para ÁLCOOL ou 'G' para GASOLINA.");
char combustivel = char.Parse(Console.ReadLine()!.ToUpper());

while (combustivel != 'A' && combustivel != 'G')
{
    Console.WriteLine($"\nOpção inválida! Digite 'A' para ÁLCOOL ou 'G' para GASOLINA!");
    combustivel = char.Parse(Console.ReadLine()!.ToUpper());
}

Console.WriteLine($"\nAgora, digite a quantidade de litros desejada:");
float litros = float.Parse(Console.ReadLine()!);

while (litros < 0)
{
    Console.WriteLine($"\nValor inválido! Digite um valor positivo!");
    litros = float.Parse(Console.ReadLine()!);
}

switch (combustivel)
{
    case 'G':
        desconto = CalculoGasolina(litros, desconto);
        valor = precoGasolina * litros;
        break;
    case 'A':
        desconto = CalculoAlcool(litros, desconto);
        valor = precoAlcool * litros;
        break;
    default:
        break;
}


valorDescontado = valor - (valor * desconto);
float descontoPorcentagem = desconto * 100;
Console.WriteLine($"\nValor sem desconto: R$ {valor}\nValor com desconto de {descontoPorcentagem}%: R$ {valorDescontado}");

//! V1
// float precoAlcool = 4.90F;
// float precoGasolina = 5.30F;
// float valor = 0;
// float valorDescontado = 0;

// Console.WriteLine($"\nPOSTO SAMPAIO");

// Console.WriteLine($"\nEscolha o tipo de combustível: \nDigite 'A' para ÁLCOOL ou 'G' para GASOLINA.");
// char combustivel = char.Parse(Console.ReadLine()!.ToUpper());

// while (combustivel != 'A' && combustivel != 'G')
// {
//     Console.WriteLine($"\nOpção inválida! Digite 'A' para ÁLCOOL ou 'G' para GASOLINA!");
//     combustivel = char.Parse(Console.ReadLine()!.ToUpper());
// }

// Console.WriteLine($"\nAgora, digite a quantidade de litros desejada:");
// float litros = float.Parse(Console.ReadLine()!);

// while (litros < 0)
// {
//     Console.WriteLine($"\nValor inválido! Digite um valor positivo!");
//     litros = float.Parse(Console.ReadLine()!);
// }

// if (combustivel == 'A')
// {

//     float desconto = 0;

//     if (litros > 0 && litros <= 20)
//     {
//         desconto = (float)3 / 100;
//     }
//     else if (litros > 20)
//     {
//         desconto = (float)5 / 100;
//     }

//     valor = precoAlcool * litros;
//     valorDescontado = valor - (valor * desconto);
// }
// else if (combustivel == 'G')
// {
//     float desconto = 0;

//     if (litros > 0 && litros <= 20)
//     {
//         desconto = (float)4 / 100;
//     }
//     else if (litros > 20)
//     {
//         desconto = (float)6 / 100;
//     }

//     valor = precoGasolina * litros;
//     valorDescontado = valor - (valor * desconto);
// }

// Console.WriteLine($"\nValor sem desconto: R$ {valor}\nValor com desconto: R$ {valorDescontado}");
