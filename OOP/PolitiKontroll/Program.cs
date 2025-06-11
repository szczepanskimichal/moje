namespace PolitiKontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Sjafor> drivers = new List<Sjafor>
            {
                new Sjafor ("Michal", true, false, true, 0.00, 60),
                new Sjafor ("Kari", false, true, true, 0.01, 70)
            };


            Console.WriteLine("Liste over sjafårer:");
            foreach (var driver in drivers)
            {
                Console.WriteLine($"Navn: {driver.Name}, Belte {driver.Seatbelt}, Mobil: {driver.UsesPhone})");
                Console.WriteLine( $"Førerkort: {driver.DriverLicense}, Promille: {driver.Speed}, Fart: {driver.Alko} km/t");
            }
            
            Console.ReadKey();//pauza
        }
    }
}
