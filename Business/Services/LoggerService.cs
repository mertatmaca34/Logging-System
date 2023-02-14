using Business.Interfaces;
using Data_Acces;
using Data_Acces.Interfaces;
using Data_Acces.Repositories;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class LoggerService : ILoggerService
    {
        ILoggerRepository loggerRepository = new LoggerRepository();


        public void Add(DateTime TimeStamp, string EventType, string Source, string User, string Message)
        {
            var log = new Log
            {
                TimeStamp = TimeStamp,
                EventType = EventType,
                Source = Source,
                User = User,
                Message = Message
            };
            loggerRepository.Add(log);
        }

        public IEnumerable<Log> GetAll()
        {
            return loggerRepository.GetAll();
        }
    }
}
