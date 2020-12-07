using ReisLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class ReisReservatie : ILoggable
    {
        public Reisbureau Reisbureau { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public LogMessage LogMessage { get; }

        public ReisReservatie(Reis reis, Reisbureau reisbureau, Persoon persoon)
        {
            Reis = reis;
            Reisbureau = reisbureau;
            Persoon = persoon;
        }
        LogMessage ILoggable.LogMessage()
        {
            return new LogMessage($"{Reisbureau} {Reis} {Persoon}");
        }
    }
}
