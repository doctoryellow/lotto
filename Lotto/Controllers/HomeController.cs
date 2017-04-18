using Microsoft.AspNetCore.Mvc;
using Lotto.ViewModels;
using Lotto.Core;
using System.Linq;

namespace Lotto.Controllers
{
    public class HomeController : Controller
    {
        private ILuckyNumberService _luckyNumberService;

        public HomeController(ILuckyNumberService luckyNumberService)
        {
            _luckyNumberService = luckyNumberService;
        }

        public IActionResult Index()
        {
            var numbers = _luckyNumberService
                .DrawNumbers()
                .Take(6)
                .ToList();


            var viewModel = new HomeViewModel()
            {
                Numbers = numbers
            };

            return View(viewModel);
        }
    }
}
