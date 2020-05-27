using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdutosWeb.Models;

namespace ProdutosWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("privacy")]
        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("quem_somos")]
        [Route("quem-somos")]
        public IActionResult QuemSomos()
        {
            return View();
        }

        [Route("contatos")]
        public IActionResult Contatos()
        {
            return View();
        }

        [Route("catalogo_produtos")]
        public IActionResult Produtos()
        {
            return View();
        }

        [Route("produtos/fornecedor/{id:int}")]
        public IActionResult Produtos(int id)
        {
            return Content("Produtos do Fornecedor: " + id.ToString());
        }
        
        [Route("produtos/lista_download")]
        public IActionResult Catalogo()
        {
            var conteudo = System.IO.File.ReadAllBytes(@"c:/Projetos/arquivo.txt");
            var nome = "catalogo.txt";
            return File(conteudo, System.Net.Mime.MediaTypeNames.Application.Octet, nome);
        }
        /*
        [Route("produtos/autor_add")]
        public IActionResult Add_Autor(string Nome)
        {
            using (var db = new bibliotecaContext())
            {
                db.Autor.Add(new Autor { Nome = "André" });
                var contador = db.SaveChanges();

                foreach (var autor in db.Autor)
                {
                    return Content("Autores: " + (autor.Nome));
                }

                return Content("Nenhum autor inserido");
            }
        }
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
