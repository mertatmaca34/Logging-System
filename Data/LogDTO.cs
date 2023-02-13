using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LogDTO
    {
        public DateTime Timestamp { get; set; }
        public string EventType { get; set; }
        public string Source { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
    }
}
