namespace cadastro_produtos
{
    public class Produto
    {
        //Propriedades
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
        public Marca Marca { get; private set; }
        public Usuario CadastradoPor { get; private set; }
        //Instanciando Lista
        public List<Produto> ListaDeProdutos { get; private set; }

        //Método construtor para atribuir valores
        public Produto(int _codigo, string _nomeProduto, float _preco, DateTime _dataCadastro, Marca _marca, Usuario _cadastradoPor)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            DataCadastro = _dataCadastro;
            Marca = _marca;
            CadastradoPor = _cadastradoPor;
        }

        //Métodos
        public string Cadastrar(Produto _produto)
        {
            ListaDeProdutos.Add(_produto);
            return _produto.ToString();
        }
        public List<Produto> Listar()
        {

        }
        public string Deletar(Produto _produto)
        {

        }
    }
}