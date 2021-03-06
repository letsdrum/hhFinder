﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hhFinder.Web.Models
{
    public class FullVacancyView : VacancyModelView
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