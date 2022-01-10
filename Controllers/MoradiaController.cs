using Andor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Andor.Controllers
{
    public class MoradiaController : Controller
    {
        private readonly Contexto _context;

        public MoradiaController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Detalhes");
        }

        [HttpGet]
        public IActionResult Detalhes(int id, int pessoaId)
        {
            var moradia = _context.Moradias.Where(p => p.Id == id).ToList();
            var pessoa = _context.Pessoas.Where(p => p.Id == pessoaId).ToList();
            ViewData["_moradias"] = moradia;
            ViewData["_pessoas"] = pessoa;
            return View();
        }
    }
}
