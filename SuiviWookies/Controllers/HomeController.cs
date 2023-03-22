using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SuiviWookies.Core.Models.Configuration;
using SuiviWookies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
                              IConfiguration configuration,
                              IOptions<GameConfiguration> gameOptions)
        {
            int minXP = int.Parse(configuration["Game:XPMin"]);

            // Nous pouvons injecter l'interface iconfiguration dans le constructeur
            // Si on veur eviter cela, utiliser service.Configure
            var conf = configuration.GetSection("Game").Get<GameConfiguration>(option =>
            {

            });

            // Nous pouvons recupere la config injecte dans le moteur
            // (service.Configure<GameConfiguration>) via ligne dessous
            var config2 = gameOptions.Value;

            _logger = logger;
        }

        public IActionResult Index()
        {
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
}
