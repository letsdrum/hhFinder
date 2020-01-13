using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.Entities
{
    public class VacancyModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("area")]
        public AreaModel Area { get; set; }

        [JsonProperty("address")]
        public AddressModel Address { get; set; }

        [JsonProperty("employer")]
        public EmployerModel Employer { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("alternate_url")]
        public string AlternateURL { get; set; }
    }

    public class AreaModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class SalaryModel
    {
        public int From { get; set; }
        public int To { get; set; }
        public bool Gross { get; set; } //true - до вычета налогов

    }

    public class AddressModel
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Raw { get; set; }
    }
    public class EmployerModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alternate_url")]
        public string AlternateURL { get; set; }
    }
}
