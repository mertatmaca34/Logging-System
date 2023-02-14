using Data;
using System.Collections.Generic;

namespace Data_Acces.Interfaces
{
    public interface ILoggerRepository
    {
        IEnumerable<LogDTO> GetAll();
        void Create(LogDTO logDTO);
        void Delete(LogDTO logDTO);
        void Update(LogDTO logDTO);
    }
}
