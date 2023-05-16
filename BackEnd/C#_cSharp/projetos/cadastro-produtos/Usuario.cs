namespace cadastro_produtos
{
    public class Usuario
    {
        //Propriedades
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        //Métodos
        public string Cadastrar(Usuario _marca)
        {

        }
        public string Deletar(Usuario _marca)
        {

        }
    }
}