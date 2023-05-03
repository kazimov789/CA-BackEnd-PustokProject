using Microsoft.AspNetCore.Mvc;
using Pustok_04._05._23.DAL;

namespace Pustok_04._05._23.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _context;
        public HomeController(PustokContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
