using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Adres
    {
        public string Gemeente { get; set; }
        public string HuisNr { get; set; }
        public int Postcode { get; set; }
        public string Straat { get; set; }
        public override string ToString()
        {
            return $"\n{Straat} {HuisNr}\n{Postcode}\n{Gemeente}";
        }
    }
}
