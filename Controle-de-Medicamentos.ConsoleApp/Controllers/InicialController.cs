using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
namespace Controle_de_Medicamentos.ConsoleApp.Controllers
{
    [Route("/")]
    class InicialController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
