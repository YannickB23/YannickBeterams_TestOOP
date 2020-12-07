using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class VliegtuigVakantie : Reis
    {
        public double VliegtuigTicket { get; private set; }
        public VliegtuigVakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen, double vliegtuigTicket)
            : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
            this.VertrekDatum = vertrekDatum;
            this.TerugKeerDatum = terugkeerDatum;
            this.AantalPersonen = aantalPersonen;
            this.VliegtuigTicket = vliegtuigTicket;
        }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs() + VliegtuigTicket * AantalPersonen;
        }
    }
}
