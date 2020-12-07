using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Reisbureau
    {
        public Adres Adres { get; set; }
        public string Naam { get; set; }

        public override string ToString()
        {
            return $"{Naam} {Adres}";
        }
    }
}
