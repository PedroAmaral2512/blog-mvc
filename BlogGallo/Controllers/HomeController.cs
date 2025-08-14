using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogGallo.Models;
using System.Threading.Tasks.Dataflow;

namespace BlogGallo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Categoria tecnologia = new ();
        tecnologia.Id = 1;
        tecnologia.Nome = "Tecnologia";
        Categoria categoria2 = new()
        {
            Id = 2,
            Nome = "IA"
        };
    
        List<Postagem> postagens = [
                new() {
                    Id = 1,
                    Nome = "Farofa picante!",
                    CategoriaId = 2,
                    Categoria = categoria2,
                    DataPostagem = DateTime.Parse("08/08/2025"),
                    Descricao = "Farofa muito boa!",
                    Texto = "Para fazer uma farofa picante, comece aquecendo duas colheres de sopa de manteiga junto com uma colher de sopa de óleo em uma frigideira grande. Se quiser, pode usar também cubos de bacon: frite-os primeiro até ficarem dourados e crocantes, depois reserve e use a gordura para refogar os ingredientes. Acrescente uma cebola média picada e refogue até dourar levemente. Em seguida, adicione dois dentes de alho picados, meio pimentão vermelho picado (opcional), uma pimenta dedo-de-moça picada (sem sementes, se quiser menos ardido) e uma colher de chá de pimenta calabresa seca. Refogue tudo por alguns minutos, mexendo sempre para não queimar. Abaixe o fogo e adicione uma xícara de farinha de mandioca aos poucos, mexendo bem para incorporar os sabores. Tempere com sal a gosto. Se tiver usado bacon, volte com ele à farofa nesse momento. Finalize com cheiro-verde picado (salsinha e cebolinha) e sirva quente ou em temperatura ambiente. Para deixar a farofa ainda mais ardida, você pode aumentar a quantidade de pimenta calabresa ou adicionar um pouco de molho de pimenta ou páprica picante ao refogado.",
                    Thumbnail = "/img/farofa.png",
                    Foto = "/img/farofa.png"
                },

        ];
        return View(postagens);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
