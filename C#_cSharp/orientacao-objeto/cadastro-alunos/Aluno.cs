namespace cadastro_alunos
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public void VerMediaFinal()
        {
            Console.WriteLine($"\nO valor da média final é: {mediaFinal}");

        }
        public void VerMensalidade()
        {
            Console.WriteLine($"\nO valor da mensalidade é: {valorMensalidade}");

        }
    }
}