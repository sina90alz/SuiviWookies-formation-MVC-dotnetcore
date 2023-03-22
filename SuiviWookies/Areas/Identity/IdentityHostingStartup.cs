using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuiviWookies.Areas.Identity.Data;
using SuiviWookies.Data;

[assembly: HostingStartup(typeof(SuiviWookies.Areas.Identity.IdentityHostingStartup))]
namespace SuiviWookies.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SuiviWookiesContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SuiviWookiesContextConnection")));

                services.AddDefaultIdentity<SuiviWookiesUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SuiviWookiesContext>();
            });
        }
    }
}