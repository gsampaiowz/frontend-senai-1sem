using Microsoft.AspNetCore.Mvc;
using projeto_gamer.Infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [TempData]
        public string Message { get; set; }

        //Instância do objeto da classe Context
        Context c = new Context();

        [Route("Login")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador jogadorBuscado = c.Jogador.FirstOrDefault(jogadorBuscado => jogadorBuscado.Email == email && jogadorBuscado.Senha == senha)!;

            //lógica da sessão
            if (jogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome!);
                return LocalRedirect("~/");
            }

            Message = "Dados inválidos, tente novamente!";
            return LocalRedirect("~/Login/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}