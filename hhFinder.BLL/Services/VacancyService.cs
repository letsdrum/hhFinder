using hhFinder.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hhFinder.BLL.Models;
using hhFinder.DAL.Interfaces;
using hhFinder.DAL;
using AutoMapper;

namespace hhFinder.BLL.Services
{
    public class VacancyService : IVacancyService
    {
        private IRepository<FullVacancy> repository;

        public VacancyService(IRepository<FullVacancy> repository)
        {
            this.repository = repository;
        }
        public List<FullVacancyDTO> GetVacancies(string Params)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FullVacancy, FullVacancyDTO>()).CreateMapper();
            return mapper.Map<List<FullVacancy>, List<FullVacancyDTO>>(repository.GetVacancies(Params));
        }

        public FullVacancyDTO GetVacancy(string id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FullVacancy, FullVacancyDTO>()).CreateMapper();
            return mapper.Map<FullVacancy, FullVacancyDTO>(repository.GetVacancy(id));
        }
    }
}
