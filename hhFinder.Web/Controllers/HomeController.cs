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

namespace hhFinder.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.hh.ru/vacancies?text=%D1%82%D0%B5%D1%81%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D1%89%D0%B8%D0%BA&area=24");
            request.UserAgent = "hhFinder/1.0 (letsdrumm@gmail.com)";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            VacancyJson list = JsonConvert.DeserializeObject<VacancyJson>(json);     
            var ListOfVacancies = new List<FullVacancy>();

            foreach(var item in list.vac)
            {
                HttpWebRequest requestVacancy = (HttpWebRequest)WebRequest.Create("https://api.hh.ru/vacancies/" + item.Id);
                requestVacancy.UserAgent = "hhFinder/1.0 (letsdrumm@gmail.com)";
                HttpWebResponse responseVacancy = (HttpWebResponse)requestVacancy.GetResponse();
                Stream streamVacancy = responseVacancy.GetResponseStream();
                StreamReader readerVacancy = new StreamReader(streamVacancy);
                var VacancyObj = JsonConvert.DeserializeObject<FullVacancy>(readerVacancy.ReadToEnd());
                ListOfVacancies.Add(VacancyObj);
            }
            ViewBag.List = ListOfVacancies;

            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}