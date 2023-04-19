//criação de variáveis
int tamanhoArrays = 2;

string[] nomes = new string[tamanhoArrays];
float[] precos = new float[tamanhoArrays];
bool[] promocoes = new bool[tamanhoArrays];

int posFinal = 0;
static void CadastrarProduto(string[] nomes, float[] precos, bool[] promocoes, int pos, int posFinal)
{
    Console.WriteLine($"\nDigite o nome do produto: ");
    nomes[pos] = Console.ReadLine()!;
    Console.WriteLine($"\nDigite o preço do produto: ");
    precos[pos] = float.Parse(Console.ReadLine()!);
    string promocao;
    do
    {
        Console.WriteLine($"\nO produto está em promoção? s/n ");
        promocao = Console.ReadLine()!.ToLower();
        if (promocao == "s")
        {
            promocoes[pos] = true;
        }
        else
        {
            promocoes[pos] = false;
        }
    } while (promocao != "s" && promocao != "n");
}

static void ListarProdutos(string[] nomes, float[] precos, bool[] promocoes, int pos, int posFinal)
{

    if (promocoes[pos])
    {
        Console.WriteLine(@$"
            Produto: {nomes[pos]}
            Preço: {precos[pos]}
            Está em promoção? Sim");
    }
    else
    {
        Console.WriteLine(@$"
            Produto: {nomes[pos]}
            Preço: {precos[pos]}
            Está em promoção? Não");
    }

}
string opcao;
do
{
    Console.ResetColor();
    Console.WriteLine(@$"
Menu de opções
[1] - Cadastrar produto (máximo de {tamanhoArrays} produtos)
[2] - Listar produtos cadastrados
[0] - Encerrar programa
");
    opcao = Console.ReadLine()!;
    Console.WriteLine($"-----------------------------------");
    switch (opcao)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            string maisCadastro;
            do
            {
                for (var i = posFinal; i < posFinal + 1; i++)
                {
                    if (i == tamanhoArrays)
                    {
                        Console.WriteLine($"\nImpossível cadastrar mais produtos. Limite atingido!");
                        break;
                    }
                    while (i < tamanhoArrays)
                    {
                        CadastrarProduto(nomes, precos, promocoes, i, posFinal);
                    }


                }
                posFinal++;
                Console.WriteLine($"\nQuer cadastrar mais um produto? ");
                maisCadastro = Console.ReadLine()!;
            } while (maisCadastro == "s");

            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (var i = 0; i < posFinal; i++)
            {
                ListarProdutos(nomes, precos, promocoes, i, posFinal);
            }
            break;
        case "0":
            Console.WriteLine($"\nEncerrando...");
            Thread.Sleep(3000);
            Console.WriteLine($"\nPrograma encerrado.");
            break;
        default:
            Console.WriteLine($"\nOpção inválida!");
            break;
    }
} while (opcao != "0");
