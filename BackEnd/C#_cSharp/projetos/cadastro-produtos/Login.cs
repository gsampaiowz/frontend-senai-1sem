namespace cadastro_produtos
{
    public class Login
    {
        //Propriedades
        public bool Logado { get; private set; }

        //Métodos
        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }
        }
        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"\nDigite seu email:");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite a senha:");
            string senhaDigitada = Console.ReadLine();

            if (emailDigitado == usuario.Email && senhaDigitada == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"\nLogin efetuado com sucesso!");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"\nDados incorretos!");
            }
        }
        public void Deslogar(Usuario usuario)
        {
            this.Logado = false;
            Console.WriteLine($"\nDesconectado com sucesso!");

        }
        public void GerarMenu()
        {
            Produto p = new Produto();
            Marca marca = new Marca();

            string opcao = string.Empty;
            do
            {
                Console.WriteLine(@$"
            <MENU>
            [1] - Cadastrar produto
            [2] - Listar produtos
            [3] - Remover produto
            
            [4] - Cadastrar marca
            [5] - Listar marcas
            [6] - Remover marca
            
            [0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        p.Cadastrar();
                        break;
                    case "2":
                        p.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"\nInforme o código do produto que deseja remover: ");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        p.Deletar(codigoProduto);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"\nInforme o código da marca que deseja remover: ");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine($"\nSaindo da aplicação...");
                        Thread.Sleep(1000);
                        Console.WriteLine($"\nEncerrado.");
                        break;
                    default:
                        Console.WriteLine($"\nOpção inválida.");
                        break;
                }
            } while (opcao != "0")



        }
    }
}