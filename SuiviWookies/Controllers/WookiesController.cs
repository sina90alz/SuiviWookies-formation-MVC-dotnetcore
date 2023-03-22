using Microsoft.AspNetCore.Mvc;
using SuiviWookies.Core.Interface.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Services;
using SuiviWookies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Controllers
{
    public class WookiesController : Controller
    {
        private readonly WookieService _service;
        private readonly IWeaponService<Weapon> _weaponService;

        public WookiesController(WookieService wookieService,
                                 IWeaponService<Weapon> weaponService)
        {
            this._service = wookieService;
            this._weaponService = weaponService;
        }

        public IActionResult Index()
        {
            List<Wookie> collection = new List<Wookie>()
                {
                    new Wookie(),
                    new Wookie()
                };

            this.ViewBag.Collection = collection;
            return View();
        }

        public IActionResult Index2()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon() { Id = 1, Label = "Blazour" },
                new Weapon() { Id = 2, Label = "LazerSabre" }
            };

            List<Wookie> collection = new List<Wookie>()
            {
                new Wookie(),
                new Wookie()
            };

            WookiesViewModel wookiesViewModel = new WookiesViewModel()
            {
                Weapons = weapons,
                Wookies = collection
            };

            return View("Index", wookiesViewModel);
        }

        public async Task<IActionResult> Index3()

        {
            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon() { Id = 1, Label = "Blazour" },
                new Weapon() { Id = 2, Label = "LazerSabre" }
            };

            WookiesViewModel wookiesViewModel = new WookiesViewModel()
            {
                Weapons = weapons,
                Wookies = await _service.GetAll()
            };

            return View("Index", wookiesViewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ActionResult result = this.View();

            if (id <= 0)
            {
                result = this.RedirectToAction("Add", "Wookies");
            }

            return result;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View(CreateDefaultViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(WookieViewModel test)
        {
            if (this.ModelState.IsValid)
            {
                await this._service.Save(test.Wookie);

            }

            return this.View(CreateDefaultViewModel());
        }

        [HttpPost]
        [ResponseCache(Duration = 0, NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult VerifyUnique(string surname)
        {
            var isValide = this._service.VerufyUnic(surname);
            return this.Json(isValide);
        }

        #region Internal Methods
        private IList<Weapon> GetWeaponList()
        {
            return this._weaponService.GetAll();
        }

        private WookieViewModel CreateDefaultViewModel()
        {
            WookieViewModel wookieViewModel = new()
            {
                Weapons = this.GetWeaponList()
            };

            return wookieViewModel;
        }
        #endregion
    }
}
