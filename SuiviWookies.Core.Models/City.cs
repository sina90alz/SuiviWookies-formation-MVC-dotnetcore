using SuiviWookies.Core.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Models
{
    public class City : BaseModel
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Latitude { get; set; }
        public double longitude { get; set; }
        public int BirthCout { get; set; }
    }
}
