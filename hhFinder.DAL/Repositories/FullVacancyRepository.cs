using hhFinder.DAL.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.DAL.Repositories
{
    public class FullVacancyRepository : IRepository<FullVacancy>
    {
        private string EndPoint;
        private string UserAgent;

        public FullVacancyRepository(string EndPoint, string UserAgent)
        {
            this.EndPoint = EndPoint;
            this.UserAgent = UserAgent;
        }

        public List<FullVacancy> GetVacancies(string Params)
        {
            HttpWebRequest requestVacancies = (HttpWebRequest)WebRequest.Create(EndPoint + "?" + Params);
            requestVacancies.UserAgent = UserAgent;

            HttpWebResponse response = (HttpWebResponse)requestVacancies.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            var json = reader.ReadToEnd();

            VacancyJson vacancyJson = JsonConvert.DeserializeObject<VacancyJson>(json);
            var ListOfVacancies = new List<FullVacancy>();

            foreach (var item in vacancyJson.VacancyList)
            {
                ListOfVacancies.Add(GetVacancy(Convert.ToString(item.Id)));
            }

            return ListOfVacancies;
        }

        public FullVacancy GetVacancy(string id)
        {
            HttpWebRequest requestVacancy = (HttpWebRequest)WebRequest.Create(EndPoint + "/" + id);
            requestVacancy.UserAgent = UserAgent;

            HttpWebResponse responseVacancy = (HttpWebResponse)requestVacancy.GetResponse();
            Stream streamVacancy = responseVacancy.GetResponseStream();
            StreamReader readerVacancy = new StreamReader(streamVacancy);

            var json = readerVacancy.ReadToEnd();
            return JsonConvert.DeserializeObject<FullVacancy>(json);
        }
    }
}
