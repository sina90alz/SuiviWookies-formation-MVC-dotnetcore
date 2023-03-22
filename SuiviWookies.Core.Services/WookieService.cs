using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.Services
{
    public class WookieService
    {
        #region Fields
        private readonly MainDbContext _context;
        #endregion

        #region Constructor
        public WookieService(MainDbContext mainDbContext)
        {
            this._context = mainDbContext;
        }
        #endregion

        public async Task<IList<Wookie>> GetAll()
        {

            return await Task.FromResult(this._context.Wookies.ToList());
        }

        public async Task Save(Wookie wookie)
        {
            this._context.Wookies.Add(wookie);
            await this._context.SaveChangesAsync();
        }

        public bool VerufyUnic(string label)
        {
            return !this._context.Wookies.Any(wookie => wookie.Surname.ToLower() == label.ToLower());
        }
    }
}
