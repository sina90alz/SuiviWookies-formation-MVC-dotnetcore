using SuiviWookies.Core.Interface.Services;
using SuiviWookies.Core.Models;
using System.Collections.Generic;

namespace SuiviWookies.Core.Services
{
    public class CityService : ICityService<City>
    {
        private readonly IBirthService _birthService;

        public CityService(IBirthService service)
        {
            _birthService = service;
        }

        public IList<City> GetAll()
        {
            IList<City> cities = new List<City>() { new City() { Id = 1, BirthCout = _birthService.Compute(1)},
                                                            new City() { Id = 2, BirthCout = _birthService.Compute(2)} };

            return cities;
        }

        //public async Task<IList<Village>> GetAll()
        //{
        //    IList<Village> villages = new List<Village>()
        //    {
        //        new Village() { }
        //    };

        //    return await Task.FromResult(villages);
        //}
    }
}
