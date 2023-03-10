using System.Collections.Generic;
using System.Data;

namespace Data_Acces.Interfaces
{
    public interface ILoggerRepository
    {
        List<Log> GetAll();
        void Add(Log log);
        void Delete(Log log);
        void Update(Log log);
    }
}
