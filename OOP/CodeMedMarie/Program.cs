namespace CodeMedMarie
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Du er under politikontrloll");
            bool belte = polititest();

            if (belte)
            {
                Console.WriteLine("Du har belte på, politiman er snill");
            }
            else
            {
                Console.WriteLine("du fikk en but");
            }
        }

        private static bool polititest()
        {
            bool belte = true;
            bool mobilBruk = true;
            int hastighet = 60;
            bool drunk = true;
            return belte;
        }

        public void Polititest(bool belte, bool mobilBruk, int hastighet, bool drunk);
                
        }
    }
}
