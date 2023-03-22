using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Interface.Services;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class WeaponService : IWeaponService<Weapon>
    {
        #region Fields
        private readonly MainDbContext _context;
        #endregion

        public WeaponService(MainDbContext mainDbContext)
        {
            this._context = mainDbContext;
        }

        public IList<Weapon> GetAll()
        {
            return this._context.Weapons.ToList();
        }
    }
}
