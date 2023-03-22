using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Models
{
    public class Wookie
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public float Size { get; set; }
        public Weapon MainWeapon { get; set; }
    }
}
