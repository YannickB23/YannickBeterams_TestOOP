using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Cruise : Reis
    {
        private const double _cruisePrijsExtra = 10;
        public bool VIP { get; private set; }
        public override double BerekenPrijs()
        {
            if (VIP)
            {
                return base.BerekenPrijs() + (_cruisePrijsExtra * AantalPersonen) * 1.5;
            }
            else
            {
                return base.BerekenPrijs() + (_cruisePrijsExtra * AantalPersonen);
            }
        }
        public Cruise(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen, bool vip = true)
            :base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
            this.VertrekDatum = vertrekDatum;
            this.TerugKeerDatum = terugkeerDatum;
            this.AantalPersonen = aantalPersonen;
            this.VIP = vip;
        }
    }
}
