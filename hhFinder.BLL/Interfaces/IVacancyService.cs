using hhFinder.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.BLL.Interfaces
{
    interface IVacancyService
    {
        List<FullVacancyDTO> GetVacancies(string Params);
        FullVacancyDTO GetVacancy(string id);
    }
}
