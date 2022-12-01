using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.coco = Palo.COCO;
        ViewBag.trebol = Palo.TREBOL;
        ViewBag.espada = Palo.ESPADA;
        ViewBag.corazon = Palo.CORAZON;

        return View(new List<Carta>());
    }

    [HttpPost]
    public IActionResult Generar(int numero_0, string tipo_0, int numero_1, string tipo_1, int numero_2, string tipo_2, int numero_3, string tipo_3, int numero_4, string tipo_4)
    {
        List<Carta> listaCarta = new List<Carta>();

        listaCarta.Add(new Carta { Numero = numero_0, Palo = tipo_0 });
        listaCarta.Add(new Carta { Numero = numero_1, Palo = tipo_1 });
        listaCarta.Add(new Carta { Numero = numero_2, Palo = tipo_2 });
        listaCarta.Add(new Carta { Numero = numero_3, Palo = tipo_3 });
        listaCarta.Add(new Carta { Numero = numero_4, Palo = tipo_4 });

        var service = new PokerService();
        ViewBag.Jugada = service.GetJugada(listaCarta);
        return View("Index", listaCarta);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}