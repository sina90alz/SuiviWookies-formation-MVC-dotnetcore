using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public decimal Power { get; set; } = 100;
        public Collection<Wookie> Wookies { get; set; }
    }
}
