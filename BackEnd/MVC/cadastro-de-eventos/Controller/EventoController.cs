using cadastro_de_eventos.Model;
using cadastro_de_eventos.View;

namespace cadastro_de_eventos.Controller
{
    public class EventoController
    {
        //instância da Model e View
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        //método controlador para acessar a listagem dos dados
        public void ListarEventos()
        {
            //chamada da Model trazendo a lista
            List<Evento> eventos = evento.Ler();

            //chamada da View passando a lista
        }
    }
}