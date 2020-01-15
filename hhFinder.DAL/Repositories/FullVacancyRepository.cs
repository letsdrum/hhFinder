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
    class FullVacancyRepository : IRepository<FullVacancy>
    {
        private string EndPoint;
        private string UserAgent;
        private string Params;
        private ICollection<VacancyJson> VacanciesJson;

        public FullVacancyRepository(string EndPoint, string Params, string UserAgent, ICollection<VacancyJson> VacanciesJson)
        {
            this.EndPoint = EndPoint;
            this.UserAgent = UserAgent;
            this.Params = Params;
            this.VacanciesJson = VacanciesJson;
        }

        public List<FullVacancy> GetVacancies()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint + "?" + Params);
            request.UserAgent = UserAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
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

            return JsonConvert.DeserializeObject<FullVacancy>(readerVacancy.ReadToEnd());
        }
    }
}
