using Microsoft.AspNetCore.Mvc;
using Razor.Examples.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Razor.Examples.Controllers
{
    public class CheckoutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction(nameof(Success));
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}
