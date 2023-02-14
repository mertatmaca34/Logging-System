using Data_Acces;
using System;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ILoggerService
    {
        IEnumerable<Log> GetAll();
        void Add(DateTime TimeStamp, string EventType, string Source, string User, string Message);
    }
}
