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
                var dLog = ssmsContext.Log.Find(log.Timestamp);

                ssmsContext.Log.Remove(dLog);
                ssmsContext.SaveChanges();
            }
        }

        public IEnumerable<Log> GetAll()
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                return ssmsContext.Log.ToList();
            }
        }

        public void Update(Log log)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                var uLog = ssmsContext.Log.Find(log.Timestamp);

                uLog.Timestamp = log.Timestamp;
                uLog.EventType = log.EventType;
                uLog.Source = log.Source;
                uLog.User = log.User;
                uLog.Message = log.Message;

                ssmsContext.SaveChanges();
            }
        }
    }
}
