﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetVacancies(string Params);
        T GetVacancy(string id);
    }
}
