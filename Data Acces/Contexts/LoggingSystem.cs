using System.Data.Entity;

namespace DataAcces
{
    public class LoggingSystem : DbContext
    {
        public DbSet<Log> Log { get; set; }
    }
}
