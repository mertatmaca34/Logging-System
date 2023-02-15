using System.Data.Entity;

namespace Data_Acces
{
    public class LoggingSystem : DbContext
    {
        public DbSet<Log> Log { get; set; }
    }
}
