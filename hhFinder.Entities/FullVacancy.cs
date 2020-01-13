using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hhFinder.Entities
{
    public class FullVacancy : VacancyModel
    {
        [JsonProperty("description")]
        public string Description { get; set; }  
    }
}
