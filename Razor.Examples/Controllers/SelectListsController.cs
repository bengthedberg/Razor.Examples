using Microsoft.AspNetCore.Mvc;
using Razor.Examples.Models;

namespace Razor.Examples.Controllers
{
    public class SelectListsController : Controller
    {
        public IActionResult Index()
        {
            return View(new SelectListsViewModel());
        }


        [HttpPost]
        public IActionResult Index(SelectListsViewModel viewModel)
        {
            return View("Results", viewModel);
        }
    }
}

