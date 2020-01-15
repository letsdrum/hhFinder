using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhFinder.DAL.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<FullVacancy> FullVacancy { get; }
        void Save();
    }
}
