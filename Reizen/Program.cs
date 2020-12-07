using ReisLibrary.Models;
using System;

namespace Reizen
{
    class Program
    {
        private static Reisbureau[] reisbureaus = new Reisbureau[3];
        private static Reis[] reizen = new Reis[3];
        private static Persoon[] personen = new Persoon[3];
        private static ReisReservatie[] reisreservaties = new ReisReservatie[3];
        static void Main(string[] args)
        {
            CreateReisbureaus();
            CreatePersonen();
            CreateReizen();
            CreateReservaties();
            //CreatLogs();
            foreach (ReisReservatie reservatie in reisreservaties)
            {
                Console.WriteLine($"{reservatie.Persoon.Naam}\n{reservatie.Reisbureau.Naam}{reservatie.Reisbureau.Adres}");
                Console.WriteLine("Prijs van de reis = " + reservatie.Reis.BerekenPrijs() + " EUR\n");
            }
            Console.ReadLine();
        }

        //private static void CreatLogs()
        //{
        //    foreach (LogMessage message in LoggerService.Logs)
        //    {
        //        Console.WriteLine($"Log {message.ID}\n/*{message.Boodschap}*/");
        //    }
        //}

        private static void CreateReizen()
        {
            reizen[0] = new Cruise(new DateTime(13 / 04 / 2021), new DateTime(23 / 04 / 2021), 2, false);
            reizen[1] = new VliegtuigVakantie(new DateTime(09 / 01 / 2021), new DateTime(02 / 02 / 2021), 2);
            reizen[2] = new AutoVakantie(new DateTime(03 / 02 / 2021), new DateTime(18 / 02 / 2021), 4);
        }
        static void CreateReisbureaus()
        {
            reisbureaus[0] = new Reisbureau
            {
                Naam = "The flying Dutchman",
                Adres = new Adres
                {
                    Gemeente = "Postel",
                    Postcode = 2400,
                    Straat = "Busjekomtzostraat",
                    HuisNr = "56",
                }
            };
            reisbureaus[1] = new Reisbureau
            {
                Naam = "De ReisDuif",
                Adres = new Adres
                {
                    Gemeente = "Brussel",
                    Postcode = 1000,
                    Straat = "Roekoestraat",
                    HuisNr = "19",
                }
            };
            reisbureaus[2] = new Reisbureau
            {
                Naam = "Oep Otel",
                Adres = new Adres
                {
                    Gemeente = "Mechelen",
                    Postcode = 2800,
                    Straat = "Bruul",
                    HuisNr = "10",
                }
            };
        }
        static void CreatePersonen()
        {
            personen[0] = new Persoon
            {
                Voornaam = "Yannick",
                Familienaam = "Beterams",
                Adres = new Adres
                {
                    Gemeente = "Ternat",
                    Postcode = 1740,
                    Straat = "Affligemstraat",
                    HuisNr = "26C",
                }
            };
            personen[1] = new Persoon
            {
                Voornaam = "Joachim",
                Familienaam = "Van Damme",
                Adres = new Adres
                {
                    Gemeente = "Mechelen",
                    Postcode = 2800,
                    Straat = "Stadionstraat",
                    HuisNr = "257",
                }
            };
            personen[2] = new Persoon
            {
                Voornaam = "Jan",
                Familienaam = "Metdepet",
                Adres = new Adres
                {
                    Gemeente = "Antwerpen",
                    Postcode = 2000,
                    Straat = "Kaaiweg",
                    HuisNr = "3",
                }
            };
        }
        static void CreateReservaties()
        {
            reisreservaties[0] = new ReisReservatie(reizen[0], reisbureaus[2], personen[1]);
            reisreservaties[1] = new ReisReservatie(reizen[2], reisbureaus[0], personen[2]);
            reisreservaties[2] = new ReisReservatie(reizen[1], reisbureaus[1], personen[0]);
        }
    }
}
