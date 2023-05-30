using Microsoft.AspNetCore.Mvc;
using projeto_gamer.Infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        //Instância do objeto da classe Context
        Context c = new Context();

        //                               controller/action
        [Route("Listar")]//http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            //"mochila" que contém a lista das equipes
            //Podemos usar essa mochila na View de equipe
            ViewBag.Equipe = c.Equipe.ToList();
            //Retorna a View da classe Equipe
            return View();
        }


        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            novaEquipe.Nome = form["Imagem"].ToString();

            c.Equipe.Add(novaEquipe);

            c.Add(novaEquipe);

            c.SaveChanges();

            ViewBag.Equipe = c.Equipe.ToList();

            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}