﻿using System;

namespace ReisLibrary.Models
{
    public class VliegtuigVakantie : Reis
    {
        public double VliegtuigTicket { get => 120.50; }
        public VliegtuigVakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
            : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
            this.VertrekDatum = vertrekDatum;
            this.TerugKeerDatum = terugkeerDatum;
            this.AantalPersonen = aantalPersonen;
        }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs() + VliegtuigTicket * AantalPersonen;
        }
    }
}
