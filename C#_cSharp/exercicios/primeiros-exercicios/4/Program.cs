// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(@$"
---------------------------------------------------------------------------------------------------------------
          PROGRAMA PARA CALCULAR A IDADE EM ANOS E EM SEMANAS, DE ACORDO COM O ANO DE NASCIMENTO
---------------------------------------------------------------------------------------------------------------
                                                                                                             ");

Console.WriteLine($"Digite o ano que você nasceu: ");
int nasc = int.Parse(Console.ReadLine());

//Módulo para receber a data atual
int anoAtual = DateTime.Now.Year;

int anos = anoAtual - nasc;
double semanas = anos * 12 * 4.34;

Console.WriteLine(@$"A sua idade em anos é {anos}, já em semanas é aproximadamente {Math.Round(semanas, 0)}.");
