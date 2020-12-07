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
