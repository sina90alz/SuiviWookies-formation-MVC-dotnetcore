using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Interface.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Models;

namespace SuiviWookies.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService<City> _service;

        public CityController(ICityService<City> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var cities = _service.GetAll();

            CityViewModel cityViewModel = new CityViewModel()
            {
                Villages = cities
            };

            return View(cityViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(TestOne test)
        {
            // To get data which is not in auto-binding of city
            string gps = this.Request.Form["Gps"];
            return this.View();
        }

    }

    public class TestOne
    {
        public string Label { get; set; }
        public int Gps { get; set; }
        public Child OneChild { get; set; }
    }

    public class Child
    {
        public string Label { get; set; }
    }
}
