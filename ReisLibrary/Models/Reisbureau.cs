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
