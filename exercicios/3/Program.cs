// See https://aka.ms/new-console-template for more information
//* Faça um porgrama que receba 5 notas de um aluno e calcule a média aritmética. imprimir a resposta no console.

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine(@$"
---------------------------------------------------------------------------------------------------------------
          PROGRAMA PARA CALCULAR A IDADE EM ANOS E EM SEMANAS, DE ACORDO COM O ANO DE NASCIMENTO
---------------------------------------------------------------------------------------------------------------
                                                                                                             ");

Console.WriteLine($"Digite o ano que você nasceu: ");
int nasc = int.Parse(Console.ReadLine());

int anos = 2023 - nasc;
double semanas = anos * 12 * 4.34;

Console.WriteLine(@$"A sua idade em anos é {anos}, já em semanas é aproximadamente {Math.Round(semanas, 0)}.
                                                                                                          ");
                                                                                                    