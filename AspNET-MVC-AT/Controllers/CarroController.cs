using Microsoft.AspNetCore.Mvc;
using CadastroCarroMVC;
using CadastroCarroMVC.Models;

namespace CadastroCarroMVC.Controllers
{
    public class CarroController : Controller
    {
        private readonly CarroContext _context;

        public CarroController(CarroContext context)
        {
            _context = context; 
        }

    }
}
