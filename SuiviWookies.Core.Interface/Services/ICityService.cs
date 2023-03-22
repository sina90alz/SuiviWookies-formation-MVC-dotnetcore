using SuiviWookies.Core.Interface.Models;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Interface.Services
{
    public interface ICityService<T> : IBaseService<T> where T : class
    {
    }
}
