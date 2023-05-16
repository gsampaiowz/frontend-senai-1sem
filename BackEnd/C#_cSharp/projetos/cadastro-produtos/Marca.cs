namespace cadastro_produtos
{
    public class Marca
    {
        //Propriedades
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; } = DateTime.Now;

        //Métodos
        public string Cadastrar(Marca _marca)
        {

        }
        public List<Marca> Listar()
        {

        }
        public string Deletar(Marca _marca)
        {

        }
    }
}