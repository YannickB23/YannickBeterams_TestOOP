using System.Linq;


namespace ReisLibrary.Models
{
    public class LogMessage
    {
        public int ID { get; private set; }
        public string Boodschap { get; private set; }
        private int GenereerID()
        {
            if (LoggerService.Logs.Count() == 0)
            {
                return ID = 0;
            }
            else
            {
                return ID = LoggerService.Logs.Count() + ID;
            }
        }
        public LogMessage(string boodschap)
        {
            ID = GenereerID();
            Boodschap = boodschap;
        }
        
    }
}
