using Microsoft.AspNetCore.Mvc;
using projeto_gamer.Infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }
        //Instância do objeto da classe Context
        Context c = new Context();

        //                               controller/action
        [Route("Listar")]//http://localhost/Jogador/Listar
        public IActionResult Index()
        {
            //"mochila" que contém a lista dos Jogadores
            //Podemos usar essa mochila na View de Jogador
            ViewBag.Jogador = c.Jogador.ToList();
            //Retorna a View da classe Jogador
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();

            //Vem como string
            // novoJogador.Imagem = form["Imagem"].ToString();

            // //Aqui começa a lógica do upload de imagem
            // if (form.Files.Count > 0)
            // {
            //     //Armazena o arquivo da imagem
            //     var file = form.Files[0];
            //     //Encontra a pasta do projeto
            //     var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Jogadors");
            //     //Verifica se a pasta existe
            //     if (!Directory.Exists(folder))
            //     {
            //         //Cria a pasta
            //         Directory.CreateDirectory(folder);
            //     }
            //     //
            //     var path = Path.Combine(folder, file.FileName);
            //     //
            //     using (var stream = new FileStream(path, FileMode.Create))
            //     {
            //         //Copia para o caminho
            //         file.CopyTo(stream);
            //     }

            //     novoJogador.Imagem = file.FileName;
            // }
            // else
            // {
            //     novoJogador.Imagem = "padrao.png";
            // }

            c.Jogador.Add(novoJogador);
            //c.Add(novoJogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                Jogador e = c.Jogador.First(e => e.IdJogador == id);

                c.Jogador.Remove(e);

                c.SaveChanges();

                return LocalRedirect("~/Jogador/Listar");
            }
            catch (System.Exception ex)
            {
                // TODO
                return LocalRedirect("~/Jogador/Erro");
            }
        }

        public IActionResult Editar(int id)
        {
            Jogador e = c.Jogador.First(e => e.IdJogador == id);

            ViewBag.Jogador = e;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador j)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = j.Nome;
            novoJogador.Email = j.Email;

            // //upload da imagem da Jogador atualizada
            // if (form.Files.Count > 0)
            // {
            //     var file = form.Files[0];

            //     var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Jogador");

            //     if (!Directory.Exists(folder))
            //     {
            //         Directory.CreateDirectory(folder);
            //         var path = Path.Combine(folder, file.FileName);

            //         using (var stream = new FileStream(path, FileMode.Create))
            //         {
            //             file.CopyTo(stream);
            //         }

            //         novoJogador.Imagem = file.FileName;
            //     }


            // }
            // else
            // {
            //     novoJogador.Imagem = "padrao.png";
            // }


            Jogador Jogador = c.Jogador.First(x => x.IdJogador == j.IdJogador);

            Jogador.Nome = novoJogador.Nome;
            Jogador.Email = novoJogador.Email;

            c.Jogador.Update(Jogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Erro");
        }
    }
}