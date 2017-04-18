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
                .OrderBy(n => n)
                .ToList();


            var balls = numbers
                .Select(n => new BallViewModel
                {
                    Number = n,
                    Class = $"ball{n.ToString("00").Substring(0,1)}"
                })
                .ToList();


            var viewModel = new HomeViewModel()
            {
                Balls = balls
            };

            return View(viewModel);
        }
    }
}
