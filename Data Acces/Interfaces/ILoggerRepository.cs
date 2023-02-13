using Data;
using System.Collections.Generic;

namespace Data_Acces.Interfaces
{
    internal interface ILoggerRepository
    {
        List<LogDTO> logDTOs();
        void Create(LogDTO logDTO);
        void Delete(LogDTO logDTO);
        void Update(LogDTO logDTO);
    }
}
