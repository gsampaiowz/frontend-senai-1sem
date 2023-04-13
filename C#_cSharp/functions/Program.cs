//* myVar = CamelCase
//* MyMethod = PascalCase

// static void BomDia()
// {
//     Console.WriteLine($"\nBom dia!");
// }

// static void BoaTarde()
// {
//     Console.WriteLine($"\nBoa tarde!");
//     //?variáveis
//     //?condicionais
//     //?repetições
//     //?arrays
// }

// static string BoaNoite()
// {
//     return $"\nBoa noite!";
// }

// static string[] BoaNoite()
// {
//     string[] saudacao = new string[2];
//     saudacao[0] = "Boa";
//     saudacao[1] = "noite!";
//     return saudacao;
// }

// BomDia();
// BoaTarde();
// Console.WriteLine(BoaNoite());

// string[] batatinha = BoaNoite();
// Console.WriteLine(batatinha);

// string texto = ($"{BoaNoite()[0]} {BoaNoite()[1]}");
// Console.WriteLine(texto);

//? mini calculadora
Console.WriteLine($"\nDigite o valor do primeiro número: ");
float n1 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"\nDigite o valor do segundo número: ");
float n2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"\n MINI CALCULADORA \nDigite: \n1 para SOMA; \n2 para SUBTRAÇÃO \n3 para MULTIPLICAÇÃO \n4 para DIVISÃO");
int operacao = int.Parse(Console.ReadLine()!);

//* criar método para somar 2 números

static float Soma(float n1, float n2)
{

    return (n1 + n2);
}

float soma = Soma(n1, n2);

//* criar método para subtrair 2 números

static float Sub(float n1, float n2)
{

    return (n1 - n2);
}

float sub = Sub(n1, n2);

//* criar método para multiplicar 2 números

static float Multi(float n1, float n2)
{

    return (n1 * n2);
}

float multi = Multi(n1, n2);

//* criar método para dividir 2 números

static float Div(float n1, float n2)
{

    return (n1 / n2);
}

float div = Div(n1, n2);

switch (operacao)
{
    case 1:
        Console.WriteLine($"\nResultado da soma: {soma}");
        break;

    case 2:
        Console.WriteLine($"\nResultado da subtração: {sub}");
        break;

    case 3:
        Console.WriteLine($"\nResultado da multiplicação: {multi}");
        break;

    case 4:
        Console.WriteLine($"\nResultado da divisão: {div}");
        break;
    default:
        Console.WriteLine($"Opção Inválida!");

        break;
}
