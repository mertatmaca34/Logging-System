using Business.Interfaces;
using Data_Acces;
using Data_Acces.Interfaces;
using System.Collections.Generic;

namespace Business.Services
{
    internal class LoggerService : ILoggerService
    {
        private readonly ILoggerRepository _repo;
        public LoggerService(ILoggerRepository repo)
        {
            _repo = repo;
        }
        public void Add(Log log)
        {
            _repo.Add(log);
        }

        public IEnumerable<Log> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
