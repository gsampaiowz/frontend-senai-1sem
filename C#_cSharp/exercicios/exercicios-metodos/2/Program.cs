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

Console.WriteLine($"\nPOSTO SAMPAIO");

Console.WriteLine($"\nEscolha o tipo de combustível: /nDigite 'A' para ÁLCOOL ou 'G' para GASOLINA.");
char combustivel = char.Parse(Console.ReadLine()!);

Console.WriteLine($"\nAgora, digite a quantidade de litros desejada");
float litros = float.Parse(Console.ReadLine()!);

float precoAlcool = 4.90F;
float precoGasolina = 5.30F;

if (combustivel == 'A')
{
    while (litros < 0)
    {
        Console.WriteLine($"\nValor inválido!");

    }
    float desconto = 0;

    if (litros > 0 && litros <= 20)
    {
        desconto = (float)3 / 100;
    }
    else if (litros > 20)
    {
        desconto = (float)5 / 100;
    }

    

    float valor = precoAlcool * litros;
    float valorDescontado = valor - (valor * desconto);
}
else if (combustivel == 'G')
{
    float desconto = 0;

    if (litros > 0 && litros <= 20)
    {
        desconto = (float)4 / 100;
    }
    else if (litros > 20)
    {
        desconto = (float)6 / 100;
    }
    else
    {
        Console.WriteLine($"\nValor inválido!");

    }

    float valor = precoGasolina * litros;
    float valorDescontado = valor - (valor * desconto);
}

Console.WriteLine($"\n SIM");
