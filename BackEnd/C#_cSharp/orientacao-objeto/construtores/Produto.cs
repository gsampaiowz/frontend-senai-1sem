namespace construtores
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        
        public Produto()
        {
            Console.WriteLine($"\nGOL do HAALAND!");
        }
        public Produto(string codigo)
        {
            Console.WriteLine($"\nGOL do BENZEMA!");
        }
        public Produto(string codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}