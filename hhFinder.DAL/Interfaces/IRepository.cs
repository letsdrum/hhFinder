using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.DAL.Interfaces
{
    interface IRepository<T> where T : class
    {
        List<T> GetVacancies();
        T GetVacancy(string id);
    }
}
