using cadastro_de_eventos.Model;

namespace cadastro_de_eventos.View
{
    public class EventoView
    {
        //método para exibir os dados da lista no console
        public void Listar(List<Evento> eventos)
        {
            Console.WriteLine($"\nLista de eventos");

            foreach (var evento in eventos)
            {
                Console.WriteLine(@$"
            Nome: {evento.Nome}
            Descrição: {evento.Descricao}
            Preço: {evento.Data}");

            }
        }
        //método para cadastrar dados
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"\nPágina de cadastro");
            Console.WriteLine($"\nDigite o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            Console.WriteLine($"\nDigite o nome do evento:");
            novoEvento.Descricao = Console.ReadLine();

            return novoEvento;
        }
    }
}