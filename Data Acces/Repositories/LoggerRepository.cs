using Data_Acces.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data_Acces.Repositories
{
    public class LoggerRepository : ILoggerRepository
    {
        public void Add(Log log)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                ssmsContext.Log.Add(log);
                ssmsContext.SaveChanges();
            }
        }

        public void Delete(Log log)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                var dLog = ssmsContext.Log.Find(log.TimeStamp);

                ssmsContext.Log.Remove(dLog);
                ssmsContext.SaveChanges();
            }
        }

        public IEnumerable<Log> GetAll()
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                return ssmsContext.Log;
            }
        }

        public void Update(Log log)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                var uLog = ssmsContext.Log.Find(log.TimeStamp);

                uLog.TimeStamp = log.TimeStamp;
                uLog.EventType = log.EventType;
                uLog.Source = log.Source;
                uLog.User = log.User;
                uLog.Message = log.Message;

                ssmsContext.SaveChanges();
            }
        }
    }
}
