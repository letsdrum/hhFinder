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
        /*  https://api.hh.ru/vacancies?text=тестировщик&area=24
         *  из такого запроса можно получить информацию:
         *  1. ID               id вакансии
         *  2. name             название вакансии
         *  3. area             место нахождения (город, id региона)
         *  4. salary           зарплата
         *  5. address          точный адрес
         *  6. employer         компания, разместившая вакансию
         *  7. published_at     дата публикации вакансии
         *  8. alternate_url    ссылка на вакансию  
         * 
         * 
         * https://api.hh.ru/vacancies/{vacancy_id}
         * пример:
         * https://api.hh.ru/vacancies/35052722
         * из такого запроса можно получить полную информацию о вакансии
         *  **1. ID               id вакансии
         *  **2. name             название вакансии
         *  **3. area             место нахождения (город, id региона)
         *  **4. salary           зарплата
         *  **5. address          точный адрес
         *  6. experience       опыт работы
         *  7. schedule         график работы (например, полный день)
         *  8. employment       тип занятости
         *  9. description     описание вакансии, содержит полное описание в формате html
         *  10. key_skills      ключевые навыки
         *  **11. employer         компания, разместившая вакансию
         *  **12. published_at     дата публикации вакансии
         *  **13. alternate_url    ссылка на вакансию  
         */

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
