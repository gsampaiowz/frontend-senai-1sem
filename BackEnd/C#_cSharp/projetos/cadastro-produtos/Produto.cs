namespace cadastro_produtos
{
    public class Produto
    {
        //Propriedades
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public string CadastradoPor { get; set; }
        //Instanciando Lista
        public static List<Produto> ListaDeProdutos = new List<Produto>();

        //Método construtor para atribuir valores
        public Produto()
        {

        }

        public Produto(int _codigo, string _nomeProduto, float _preco)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            DataCadastro = DateTime.Today;
            Usuario user = new Usuario();
            CadastradoPor = user.Nome;
        }

        //Métodos
        public static void CadastrarProduto()
        {
            Console.WriteLine($"\nDigite o código do produto:");
            int codigoDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDigite o nome do produto:");
            string nomeDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite o preço do produto:");
            float precoDigitado = float.Parse(Console.ReadLine());

            ListaDeProdutos.Add(
                new Produto(codigoDigitado, nomeDigitado, precoDigitado)
            );
        }
        public static void Listar()
        {
            if (ListaDeProdutos.Count > 0)
            {
                foreach (Produto p in ListaDeProdutos)
                {
                    Console.WriteLine(@$"
                    Codigo = {p.Codigo}
                    NomeProduto = {p.NomeProduto}
                    Preco = {p.Preco:C2}
                    DataCadastro = {p.DataCadastro}
                    Marca = {p.Marca.NomeMarca}
                    CadastradoPor = {p.CadastradoPor}");
                }
            }
            else
            {
                Console.WriteLine($"\nLista Vazia!");
            }
        }
        public static void Deletar(int codigo)
        {
            Produto removido = ListaDeProdutos.Find(x => x.Codigo == codigo);
            int index = ListaDeProdutos.IndexOf(removido);
            ListaDeProdutos.RemoveAt(index);

            Console.WriteLine($"\nProduto foi pra casa do cabrunco feio.");

        }
    }
}