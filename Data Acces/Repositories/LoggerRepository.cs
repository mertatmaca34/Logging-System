using Data_Acces.Interfaces;
using System.Collections.Generic;

namespace Data_Acces.Repositories
{
    public class LoggerRepository : ILoggerRepository
    {
        public void Add(Log log)
        {
            using (LoggingSystem LoggingSystem = new LoggingSystem())
            {
                LoggingSystem.Log.Add(log);
                LoggingSystem.SaveChanges();
            }
        }

        public void Delete(Log log)
        {
            using (LoggingSystem LoggingSystem = new LoggingSystem())
            {
                var dLog = LoggingSystem.Log.Find(log.TimeStamp);

                LoggingSystem.Log.Remove(dLog);
                LoggingSystem.SaveChanges();
            }
        }

        public List<Log> GetAll()
        {
            List<Log> logs = new List<Log>();
            using (LoggingSystem LoggingSystem = new LoggingSystem())
            {
                foreach (var item in LoggingSystem.Log)
                {
                    logs.Add(item);
                }
                return logs;
            }
        }

        public void Update(Log log)
        {
            using (LoggingSystem LoggingSystem = new LoggingSystem())
            {
                var uLog = LoggingSystem.Log.Find(log.TimeStamp);

                uLog.TimeStamp = log.TimeStamp;
                uLog.EventType = log.EventType;
                uLog.Source = log.Source;
                uLog.User = log.User;
                uLog.Message = log.Message;

                LoggingSystem.SaveChanges();
            }
        }
    }
}
