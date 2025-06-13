using System;
using System.Collections.Generic;

namespace OverrideVsNewExample
{
    // Klasa bazowa
    class Car
    {
        // Ta metoda NIE JEST virtual, więc zawsze zostanie użyta wersja z Car
        public void DescribeCar()
        {
            Console.WriteLine("Four wheels and an engine.");
            ShowDetails(); // Ta metoda JEST virtual, więc może być nadpisana
        }

        // Ta metoda może zostać nadpisana w klasach pochodnych
        public virtual void ShowDetails()
        {
            Console.WriteLine("Standard transportation.");
        }
    }

    // Klasa pochodna, która używa "new" zamiast "override"
    class ConvertibleCar : Car
    {
        // Ukrywa metodę ShowDetails z Car, ale jej nie nadpisuje
        public new void ShowDetails()
        {
            Console.WriteLine("A roof that opens up.");
        }
    }

    // Klasa pochodna, która używa "override"
    class Minivan : Car
    {
        // Nadpisuje metodę ShowDetails z Car
        public override void ShowDetails()
        {
            Console.WriteLine("Carries seven people.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test 1: wywołanie DescribeCar(), która korzysta z ShowDetails()
            TestCars1();

            // Test 2: lista obiektów typu Car, ale stworzone jako różne podtypy
            TestCars2();

            // Test 3: bezpośrednie wywołanie ShowDetails() na obiektach pochodnych
            TestCars3();

            // Test 4: wywołanie ShowDetails() na obiektach jako Car
            TestCars4();
        }

        public static void TestCars1()
        {
            Console.WriteLine("\nTestCars1");
            Console.WriteLine("----------");

            Car car1 = new Car();
            car1.DescribeCar();
            Console.WriteLine("----------");

            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar(); // Mimo że car2 to ConvertibleCar, DescribeCar pochodzi z Car
            Console.WriteLine("----------");

            Minivan car3 = new Minivan();
            car3.DescribeCar(); // Zadziała override
            Console.WriteLine("----------");
        }

        public static void TestCars2()
        {
            Console.WriteLine("\nTestCars2");
            Console.WriteLine("----------");

            List<Car> cars = new List<Car>
            {
                new Car(),
                new ConvertibleCar(),
                new Minivan()
            };

            foreach (Car car in cars)
            {
                car.DescribeCar(); // Wywołuje DescribeCar z Car, które woła ShowDetails()
                Console.WriteLine("----------");
            }
        }

        public static void TestCars3()
        {
            Console.WriteLine("\nTestCars3");
            Console.WriteLine("----------");

            ConvertibleCar car2 = new ConvertibleCar();
            Minivan car3 = new Minivan();

            car2.ShowDetails(); // Używa wersji z ConvertibleCar
            car3.ShowDetails(); // Używa override z Minivan
        }

        public static void TestCars4()
        {
            Console.WriteLine("\nTestCars4");
            Console.WriteLine("----------");

            Car car2 = new ConvertibleCar(); // Typ Car!
            Car car3 = new Minivan();        // Typ Car!

            car2.ShowDetails(); // Ponieważ ConvertibleCar używa "new", to używana jest wersja z Car
            car3.ShowDetails(); // Ponieważ Minivan używa "override", działa nowa wersja
        }
    }
}
