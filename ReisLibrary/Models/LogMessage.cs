using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class LogMessage
    {
        public int ID { get; private set; }
        public string Boodschap { get; private set; }
        private int GenereerID()
        {
            int hoogsteID = 0;
            foreach (LogMessage message in LoggerService.Logs)
            {
                if (hoogsteID <= message.ID)
                {
                    hoogsteID = message.ID;
                }
            }
                return (hoogsteID + 1);
        }
        public LogMessage(string boodschap)
        {
            ID = GenereerID();
            Boodschap = boodschap;
        }
    }
}
