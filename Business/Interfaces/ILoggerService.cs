using System;
using System.Data;

namespace Business.Interfaces
{
    public interface ILoggerService
    {
        Array GetAll();
        void Add(DateTime TimeStamp, string EventType, string Source, string User, string Message);
    }
}
