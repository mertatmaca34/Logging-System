using Business.Interfaces;
using Data_Acces;
using Data_Acces.Interfaces;
using Data_Acces.Repositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class LoggerService : ILoggerService
    {
        ILoggerRepository loggerRepository = new LoggerRepository();

        public void Add(Log log)
        {
            loggerRepository.Add(log);
        }

        public IEnumerable<Log> GetAll()
        {
            return loggerRepository.GetAll();
        }
    }
}
