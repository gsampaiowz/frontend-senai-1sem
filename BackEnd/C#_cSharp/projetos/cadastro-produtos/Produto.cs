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
        public Usuario CadastradoPor { get; set; }
        //Instanciando Lista
        public List<Produto> ListaDeProdutos = new List<Produto>();

        //Método construtor para atribuir valores
        public Produto(int _codigo, string _nomeProduto, float _preco, DateTime _dataCadastro, Marca _marca, Usuario _cadastradoPor)
        {
            this.Codigo = _codigo;
            this.NomeProduto = _nomeProduto;
            this.Preco = _preco;
            this.DataCadastro = _dataCadastro;
            this.Marca = _marca;
            this.CadastradoPor = _cadastradoPor;
        }

        //Métodos
        public string Cadastrar(Produto _produto)
        {
            ListaDeProdutos.Add(_produto);
            return _produto.ToString();
        }
        public void Listar()
        {
            if (ListaDeProdutos.Count > 0)
            {
                foreach (Produto p in ListaDeProdutos)
                {
                    Console.WriteLine(@$"
                    Codigo = {p.Codigo}
                    NomeProduto = {p.NomeProduto}
                    Preco = {p.Preco}
                    DataCadastro = {p.DataCadastro}
                    Marca = {p.Marca}
                    CadastradoPor = {p.CadastradoPor}");
                }
            }
            else
            {
                Console.WriteLine($"\nLista Vazia!");
            }
        }
        public string Deletar(int codigo)
        {
            return ListaDeProdutos.Remove(p.Codigo).ToString();
        }
    }
}