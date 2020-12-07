using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class AutoVakantie : Reis
    {
        private const double _extraPrijsHuurAuto = 10;
        private bool _eigenWagen;
        public bool EigenWagen { get; private set; }
        public AutoVakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen, bool eigenWagen)
            : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
            this.VertrekDatum = vertrekDatum;
            this.TerugKeerDatum = terugkeerDatum;
            this.AantalPersonen = aantalPersonen;
            this.EigenWagen = true;

        }
        public override double BerekenPrijs()
        {
            if (EigenWagen)
            {
                return base.BerekenPrijs();
            }
            else if (AantalPersonen > 5 || EigenWagen)
            {
                return base.BerekenPrijs() + AantalDagen * (_extraPrijsHuurAuto + _extraPrijsHuurAuto);
            }
            else
            {
                return base.BerekenPrijs() + AantalDagen * _extraPrijsHuurAuto;
            }
        }
    }
}
