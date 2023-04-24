namespace cadastro_alunos
{
    public class Aluno
    {
        public string nome = string.Empty;
        public string curso = string.Empty;
        public int idade;
        public string rg = string.Empty;
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