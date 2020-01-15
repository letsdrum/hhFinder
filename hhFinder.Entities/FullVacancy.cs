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
        public Experience Experience { get; set; }

        public Schedule Schedule { get; set; }

        public Employment Employment { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public List<Skill> KeySkills { get; set; }        
    }
   
    public class Experience
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Schedule
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    
    public class Employment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Skill
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
