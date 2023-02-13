using Data;
using System.Data.Entity;

namespace Business
{
    public class SSMSContext : DbContext
    {
        public DbSet<LogDTO> LogDTOs { get; set; }
    }
}
