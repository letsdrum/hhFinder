using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hhFinder.Entities
{
    public class VacancyJson
    {
        [JsonProperty("items")]
        public List<Vacancy> vac { get; set; }
    }
    public class Vacancy
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("alternate_url")]
        public string AlternateURL { get; set; }

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
         *  
         */
    }
}
