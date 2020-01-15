using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.Entities
{
    public class VacancyJson
    {
        [JsonProperty("items")]
        public List<VacancyModel> VacancyList { get; set; }
    }
}
