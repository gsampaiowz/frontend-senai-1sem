using cadastro_de_eventos.Model;

namespace cadastro_de_eventos.View
{
    public class EventoView
    {
        //método para exibir os dados da lista no console
        public void Listar(List<Evento> eventos)
        {
            Console.WriteLine($"\nLista de eventos");
            Console.WriteLine();
        }
    }
}