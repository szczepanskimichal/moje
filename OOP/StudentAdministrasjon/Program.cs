namespace StudentAdministrasjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenter = new()
                        {
                            new Student("Michal", 30, "IT", "876358", "DAT100", "A"),
                            new Student("Ole", 11, "IT",  "876358", "DAT100", "b")
                        };

            List<Fag> fagliste = new()
                        {
                            new Fag("MAT200", "Mathematics", 5, "Mathematics"),
                            new Fag("DAT100", "Programming", 10, "Programming")
                        };

            // Tworzymy oceny (kto co dostał z jakiego przedmiotu)    
            List<Karakter> karakterer = new()
                        {
                            new Karakter(studenter[0], fagliste[0], "A"),
                            new Karakter(studenter[0], fagliste[1], "B"),
                        };

            bool play = true;
            while (play)
            {
                Console.WriteLine("Hva cil du vise?");
                Console.WriteLine("1. Studenter");
                Console.WriteLine("2. Fagliste");
                Console.WriteLine("3. Karakterliste");
                Console.WriteLine("0. Avslutt");
                Console.Write("Velg et alternativ: ");
                string valg = Console.ReadLine();
                switch (valg)
                {
                    case "1":
                        Console.WriteLine("STUDENTER:");
                        foreach (var student in studenter)
                        {
                            student.SkrivUtInfo();
                        }
                        break;
                    case "2":
                        Console.WriteLine("FagListe:");
                        foreach (var fag in fagliste)
                        {
                            fag.SkrivUtInfo();
                        }
                        break;
                    case "3":
                        Console.WriteLine("KarakterListe");
                        foreach (var karakter in karakterer)
                        {
                            karakter.SkrivUtInfo();
                        }
                        break;
                        case "0":
                            play = false;
                        Console.WriteLine("avlutter ...");
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjrn.");
                        break;
                }
            }
        }
    }
}
