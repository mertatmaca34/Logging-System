using Data;
using Data_Acces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SSMSContext : DbContext, ILoggerRepository
    {
        public void Create(LogDTO logDTO)
        {
            throw new NotImplementedException();
        }

        public void Delete(LogDTO logDTO)
        {
            throw new NotImplementedException();
        }

        public List<LogDTO> logDTOs()
        {
            throw new NotImplementedException();
        }

        public void Update(LogDTO logDTO)
        {
            throw new NotImplementedException();
        }
    }
}
