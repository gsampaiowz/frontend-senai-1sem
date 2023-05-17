namespace cadastro_produtos
{
    public class Marca
    {
        //Propriedades
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; } = DateTime.Now;

        public List<Marca> ListaDeMarcas = new List<Marca>();
        //Métodos
        public Marca Cadastrar(Marca marca)
        {
            Marca novaMarca = new Marca();

            return novaMarca;
        }
        public void Listar()
        {

        }
        public void Deletar(int codigo)
        {

        }
    }
}