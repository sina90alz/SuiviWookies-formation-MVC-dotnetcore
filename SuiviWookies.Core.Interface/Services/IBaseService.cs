using System;
using System.Collections;
using System.Collections.Generic;

namespace SuiviWookies.Core.Interface.Services
{
    public interface IBaseService<T> where T : class
    {
        IList<T> GetAll();
    }
}
