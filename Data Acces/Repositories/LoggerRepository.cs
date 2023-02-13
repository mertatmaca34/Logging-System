using Business;
using Data;
using Data_Acces.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Repositories
{
    public class LoggerRepository : DbSet, ILoggerRepository
    {
        public void Create(LogDTO logDTO)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                ssmsContext.LogDTOs.Add(logDTO);
                ssmsContext.SaveChanges();
            }
        }

        public void Delete(LogDTO logDTO)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                var dLogDTO = ssmsContext.LogDTOs.Find(logDTO.Timestamp);

                ssmsContext.LogDTOs.Remove(dLogDTO);
                ssmsContext.SaveChanges();
            }
        }

        public List<LogDTO> logDTOs()
        {
            throw new NotImplementedException();
        }

        public void Update(LogDTO logDTO)
        {
            using (SSMSContext ssmsContext = new SSMSContext())
            {
                var uLogDTO = ssmsContext.LogDTOs.Find(logDTO.Timestamp);

                uLogDTO.Timestamp = logDTO.Timestamp;
                uLogDTO.EventType = logDTO.EventType;
                uLogDTO.Source = logDTO.Source;
                uLogDTO.User = logDTO.User;
                uLogDTO.Message = logDTO.Message;
                
                ssmsContext.SaveChanges();
            }
        }
    }
}
