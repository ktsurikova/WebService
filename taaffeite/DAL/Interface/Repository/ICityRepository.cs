using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace DAL.Interface.Repository
{
    public interface ICityRepository : IRepository<City>
    {
        List<City> GetAll(string countryName);
    }
}
