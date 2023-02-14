using Data;
using System.Data.Entity;

namespace Data_Acces
{
    public class SSMSContext : DbContext
    {
        public DbSet<Log> Log { get; set; }
    }
}
