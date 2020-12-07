using System;

namespace ReisLibrary.Models
{
    public abstract class Reis
    {
        private const double _basisDagPrijs = 40;
        public virtual double BerekenPrijs()
        {
            return AantalDagen * _basisDagPrijs;
        }
        private DateTime terugkeerDatum;
        private DateTime vertrekDatum;
        public int AantalDagen => (int)Math.Round((TerugKeerDatum - VertrekDatum).TotalDays);
        public int AantalPersonen { get; set; }
        public Reis(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
        {
            VertrekDatum = vertrekDatum;
            TerugKeerDatum = terugkeerDatum;
            AantalPersonen = aantalPersonen;
        }
        public DateTime VertrekDatum
        {
            get => vertrekDatum;
            set
            {
                if (value > DateTime.Now)
                {
                    vertrekDatum = value;
                }
            }
        }
        public DateTime TerugKeerDatum
        {
            get => terugkeerDatum;
            set
            {
                if (value > vertrekDatum && value > DateTime.Now)
                {
                    terugkeerDatum = value;
                }
            }
        }
    }
}
