using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Models
{
    public class WookiesViewModel
    {
        public IList<Wookie> Wookies { get; set; }

        public IList<Weapon> Weapons { get; set; }

        public int WeaponId { get; set; }

        public IList<City> Villages { get; set; }
    }
}
