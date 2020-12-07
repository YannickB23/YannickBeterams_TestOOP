using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;
        public static LogMessage[] Logs { get; set; }
        static LoggerService()
        {
            logs = new LogMessage[0];
        }
        public static void AddLogMessage(LogMessage message)
        {

        }
    }
}
