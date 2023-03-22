using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Interface.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Models.Configuration;
using SuiviWookies.Core.Services;

namespace SuiviWookies.ExtensionMethods
{
    public static class ServicesExtensionMethods
    {
        public static IServiceCollection AddInjectionDepepencies(this IServiceCollection service, IConfiguration configuration)
        {
            string connectString = configuration.GetConnectionString("StarWarsDatabase");

            // Ici nous pouvons injecter la config dans le moteur
            service.Configure<GameConfiguration>(configuration.GetSection("Game"));

            service.AddDbContext<MainDbContext>(options =>
            {
                options.UseSqlServer(connectString, options => { });
            });

            service.AddScoped<IBirthService, BirthService>();
            service.AddScoped<IWeaponService<Weapon>, WeaponService>();
            service.AddScoped<ICityService<City>, CityService>();
            service.AddScoped<WookieService>();

            return service;
        }
    }
}
