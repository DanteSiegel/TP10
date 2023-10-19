using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
          
        ViewBag.Series = BD.GetSeries();
        return View();
    }

    public List<Temporada> GetTemporadasSerieAjax(int idSerie){
        return BD.GetTemporadas(idSerie);
    }

    public List<Actor> GetActoresSerieAjax(int idSerie){
        return BD.GetActores(idSerie);
    }

    public Serie GetMasInfo(int idSerie){
        return GetMasInfo(idSerie);
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
