using projeto_MVC.Model;

namespace projeto_MVC.View
{
    public class ProdutoView
    {
        //método para exibir os dados da lista no console
        public void Listar(List<Produto> produtos)
        {
            Console.WriteLine($"\nLista de produtos");
            Console.WriteLine(produtos.Count());

            foreach (var produto in produtos)
            {
                Console.WriteLine(@$"
                Código: {produto.Codigo}
                Nome: {produto.Nome}
                Preço: {produto.Preco}");

            }
        }

        public void Cadastrar(Produto produto)
        {
            Console.WriteLine($"\nPágina de cadastro");
            Console.WriteLine($"\nDigite o código:");
            string? codigo = Console.ReadLine();
            Console.WriteLine($"\nDigite o nome:");
            string? nome = Console.ReadLine();
            Console.WriteLine($"\nDigite o preço:");
            string? preco = Console.ReadLine();
    
        }
    }
}