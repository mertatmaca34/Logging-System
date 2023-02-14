using Data_Acces;
using System.Collections.Generic;

namespace Business.Interfaces
{
    internal interface ILoggerService
    {
        IEnumerable<Log> GetAll();
        void Add(Log log);
    }
}
