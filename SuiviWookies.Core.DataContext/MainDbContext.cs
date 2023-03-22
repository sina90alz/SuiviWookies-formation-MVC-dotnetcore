using Microsoft.EntityFrameworkCore;
using SuiviWookies.Core.DataContext.EntityTypesConfiguration;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.DataContext
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {
        }

        public MainDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasKey(item => item.Id);

            // ou nous pouvons utiliser TypeConfiguration
            modelBuilder.ApplyConfiguration(new WookieTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WeaponTypeConfiguration());

            // Ou nous pouvons ajouter la configuration par assembly pour gagner du temps
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);
        }

        public DbSet<Wookie> Wookies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
