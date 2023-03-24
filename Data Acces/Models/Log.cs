using System;

namespace DataAcces
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string EventType { get; set; }
        public string Source { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
    }
}
