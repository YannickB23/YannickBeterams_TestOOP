using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get => Familienaam + " " + Voornaam; }

        public override string ToString()
        {
            return $"{Naam}";
        }
    }
}
