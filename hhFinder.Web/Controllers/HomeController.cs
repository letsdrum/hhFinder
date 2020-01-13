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
using hhFinder.Entities;
using System.Threading.Tasks;

namespace hhFinder.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {                       
            return View();
        }
        const string ENDPOINT_REQUEST = "https://api.hh.ru/vacancies?text=тестировщик&area=24";
        const string ENV_USERAGENT = "hhFinder/1.0 (letsdrumm@gmail.com)";


        public async Task<ActionResult> Search()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.hh.ru/vacancies?text=тестировщик&area=24");
            request.UserAgent = "hhFinder/1.0 (letsdrumm@gmail.com)";   

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            var json = await reader.ReadToEndAsync();
            VacancyJson list = JsonConvert.DeserializeObject<VacancyJson>(json);
            var ListOfVacancies = new List<FullVacancy>();

            foreach (var item in list.vac)
            {
                HttpWebRequest requestVacancy = (HttpWebRequest)WebRequest.Create("https://api.hh.ru/vacancies/" + item.Id);
                requestVacancy.UserAgent = "hhFinder/1.0 (letsdrumm@gmail.com)";
                
                HttpWebResponse responseVacancy = (HttpWebResponse)requestVacancy.GetResponse();
                Stream streamVacancy = responseVacancy.GetResponseStream();
                StreamReader readerVacancy = new StreamReader(streamVacancy);

                var VacancyObj = JsonConvert.DeserializeObject<FullVacancy>(await readerVacancy.ReadToEndAsync());
                ListOfVacancies.Add(VacancyObj);
            }

            return View(ListOfVacancies);
        }        
    }
}