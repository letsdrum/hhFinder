using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;
using hhFinder.BLL.Services;
using hhFinder.DAL.Repositories;
using AutoMapper;
using hhFinder.BLL.Models;
using hhFinder.Web.Models;

namespace hhFinder.Web.Controllers
{
    public class HomeController : Controller
    {
        const string EndPoint = "https://api.hh.ru/vacancies";
        const string UserAgent = "hhFinder/1.0 (letsdrumm@gmail.com)";        
        VacancyService service = new VacancyService(new FullVacancyRepository(EndPoint, UserAgent));

        public ActionResult Index()
        {                       
            return View();
        }

        public ActionResult Search()
        {
            var Params = "text=тестировщик&area=24";
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FullVacancyDTO, FullVacancyView>()).CreateMapper();
            var vacancies = mapper.Map<List<FullVacancyDTO>, List<FullVacancyView>>(service.GetVacancies(Params));
            return View(vacancies);
        }        
    }
}