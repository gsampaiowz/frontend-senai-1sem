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

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();

            //Vem como string
            // novaEquipe.Imagem = form["Imagem"].ToString();

            //Aqui começa a lógica do upload de imagem
            if (form.Files.Count > 0)
            {
                //Armazena o arquivo da imagem
                var file = form.Files[0];
                //Encontra a pasta do projeto
                var folder = Path.Combine(Directory.GetCurrentDirectory());
                //Verifica se a pasta existe
                if (!Directory.Exists(folder))
                {
                    //Cria a pasta
                    Directory.CreateDirectory(folder);
                }
                //
                var path = Path.Combine(folder, file.FileName);
                //
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    //Copia para o caminho
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            c.Equipe.Add(novaEquipe);
            //c.Add(novaEquipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}