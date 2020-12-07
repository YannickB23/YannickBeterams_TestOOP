using System;
using System.Linq;


namespace ReisLibrary.Models
{
    public static class LoggerService
    {
        private static LogMessage[] _logs;
        public static LogMessage[] Logs { get => _logs;
            set
            {
                _logs = value;
            }
        }
        static LoggerService()
        {
            _logs = new LogMessage[1];
        }
        public static void AddLogMessage(LogMessage message)
        {
            Logs[_logs.Length - 1] = message;
            Array.Resize(ref _logs, _logs.Count() + 1);
        }
    }
}
