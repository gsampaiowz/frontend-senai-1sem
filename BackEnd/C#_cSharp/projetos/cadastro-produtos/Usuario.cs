namespace cadastro_produtos
{
    public class Usuario
    {
        //Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        //Métodos
        public Usuario()
        {
            Cadastrar();
        }
        public void Cadastrar(string _nome, string _email, string _senha, DateTime _dataCadastro)
        {
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.DataCadastro = _dataCadastro;
        }
        public string Deletar(Usuario usuario)
        {

        }
    }
}