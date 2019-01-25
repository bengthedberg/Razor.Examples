using Microsoft.AspNetCore.Mvc;
using Razor.Examples.Models;

namespace Razor.Examples.Controllers
{
    public class TagHelpersController : Controller
    {
        public IActionResult Index()
        {
            return View(new TagHelpersViewModel());
        }

        [HttpPost]
        public IActionResult Index(TagHelpersViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "The validation succeeded, but here's a model error for you!");
            }
            return View(viewModel);
        }
    }
}
