using ReisLibrary.Interfaces;

namespace ReisLibrary.Models
{
    public class ReisReservatie : ILoggable
    {
        public Reisbureau Reisbureau { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }

        public ReisReservatie(Reis reis, Reisbureau reisbureau, Persoon persoon)
        {
            Reis = reis;
            Reisbureau = reisbureau;
            Persoon = persoon;
            LoggerService.AddLogMessage(LogMessage());
        }
        public LogMessage LogMessage()
        {
            return new LogMessage($"{Reisbureau} {Reis} {Persoon}");
        }
    }
}
