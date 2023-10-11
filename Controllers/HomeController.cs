using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "085.877.903-40", "Arthurf30@gmail.com", "Tamandua");
        Cliente cliente2 = new Cliente(02, "Matheus A. Ferreira", "500.877.903-40", "Matheus10@gmail.com", "Rinoceronte");
        Cliente cliente3 = new Cliente(03, "Ananias A. Ferreira", "700.877.903-40", "Ananias12@gmail.com", "Leão");
        Cliente cliente4 = new Cliente(04, "Malaquias A. Ferreira", "200.877.903-40", "Malaquias20@gmail.com", "Zebra");
        Cliente cliente5 = new Cliente(05, "Eunuco A. Ferreira", "100.877.903-40", "Eunuco69@gmail.com", "Chinchila");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(01, "So Racao", "24.224.102/001-80", "sr-pet@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Racao", "24.224.102/001-80", "racao@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "Cachorro Loko", "24.224.102/001-80", "CLOKO@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "Big dog", "24.224.102/001-80", "BG@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "Morde e assopra", "24.224.102/001-80", "Mapet@pet.org");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
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
