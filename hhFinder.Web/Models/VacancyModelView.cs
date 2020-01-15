using Newtonsoft.Json;

namespace hhFinder.Web.Models
{
    public class VacancyModelView
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("area")]
        public AreaModel Area { get; set; }

        //[JsonProperty("salary")]
        //public SalaryModel Salary { get; set; }

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
        public string Url { get; set; }
    }

    //public class SalaryModel
    //{
    //    [JsonProperty("from")]
    //    public decimal From { get; set; }

    //    [JsonProperty("to")]
    //    public decimal To { get; set; }

    //    [JsonProperty("gross")]
    //    public bool Gross { get; set; } //true - до вычета налогов
    //}

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