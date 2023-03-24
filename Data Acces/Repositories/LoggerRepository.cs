using DataAcces.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAcces.Repositories
{
    public class LoggerRepository : IRepository<Log>
    {
        private readonly LoggingSystem context = new LoggingSystem();

        public IEnumerable<Log> GetAll()
        {
            return context.Set<Log>().ToList();
        }

        public Log GetById(object id)
        {
            return context.Set<Log>().Find(id);
        }

        public void Insert(Log entity)
        {
            context.Set<Log>().Add(entity);
            context.SaveChanges();
        }

        public void Update(Log entity)
        {
            context.Set<Log>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(object id)
        {
            var entity = context.Set<Log>().Find(id);
            if (entity != null)
                context.Set<Log>().Remove(entity);
            context.SaveChanges();
        }
    }
}
