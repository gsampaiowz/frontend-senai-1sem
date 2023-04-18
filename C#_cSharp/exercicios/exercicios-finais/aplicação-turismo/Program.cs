// See https://aka.ms/new-console-template for more information

string[] nomePassageiros = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

// static string CadastroPassagem()
// {
//     string[] nomePassageiros = new string[5];
//     string[] origem = new string[5];
//     string[] destino = new string[5];
//     string[] data = new string[5];
//     for (var i = 0; i < nomePassageiros.Length; i++)
//     {
//         Console.WriteLine($"\nDigite o nome do {i + 1}º passageiro: ");
//         nomePassageiros[i] = Console.ReadLine()!;
//         Console.WriteLine($"\nDigite a origem do {i + 1}º passageiro: ");
//         origem[i] = Console.ReadLine()!;
//         Console.WriteLine($"\nDigite o destino do {i + 1}º passageiro: ");
//         destino[i] = Console.ReadLine()!;
//         Console.WriteLine($"\nDigite a data da viagem do {i + 1}º passageiro: Exemplo: 26/05/2023");
//         data[i] = Console.ReadLine()!;
//     }
// }

Console.WriteLine($"\nAgência de Turismo");

Console.WriteLine($"\nDigite a senha de acesso: ");
string senha = Console.ReadLine()!;

while (senha != "haaland")
{
    Console.WriteLine($"\nSenha incorreta!");
    senha = Console.ReadLine()!;
}

Console.WriteLine($"\nCarregando...");
Thread.Sleep(3000);

Console.WriteLine($"\nAcesso bem sucedido!");

Console.WriteLine(@$"
_________________________
|          Menu         |
|-----------------------|
| 1. Cadastrar passagem | 
| 2. Listar passagens   |
| 0. Sair               | 
-------------------------");

Console.WriteLine($"\nO que deseja fazer?");
int escolha = int.Parse(Console.ReadLine()!);

switch (escolha)
{
    case 1:
        for (var i = 0; i < nomePassageiros.Length; i++)
        {
            Console.WriteLine($"\nDigite o nome do {i + 1}º passageiro: ");
            nomePassageiros[i] = Console.ReadLine()!;
            Console.WriteLine($"\nDigite a origem do {i + 1}º passageiro: ");
            origem[i] = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o destino do {i + 1}º passageiro: ");
            destino[i] = Console.ReadLine()!;
            Console.WriteLine($"\nDigite a data da viagem do {i + 1}º passageiro: Exemplo: 26/05/2023");
            data[i] = Console.ReadLine()!;
        }
        break;
    case 2:
        for (var i = 0; i < nomePassageiros.Length; i++)
        {
            Console.WriteLine($"\n O nome do {i + 1}º passageiro: {nomePassageiros[i]}");
            Console.WriteLine($"\n A origem do {i + 1}º passageiro: {origem[i]}");
            Console.WriteLine($"\n O destino do {i + 1}º passageiro: {destino[i]}");
            Console.WriteLine($"\n A data da viagem do {i + 1}º passageiro: {data[i]}");

        }
        break;
    case 0:

        break;
}
