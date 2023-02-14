using Data_Acces;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ILoggerService
    {
        IEnumerable<Log> GetAll();
        void Add(Log log);
    }
}
