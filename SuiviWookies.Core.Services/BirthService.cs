using SuiviWookies.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class BirthService : IBirthService
    {
        public int Compute(int cityId)
        {
            Random r = new();
            return r.Next(1, 500);
        }
    }
}
