using System;

namespace TrafficLightDemo
{
    public class TrafficLightDemo1
    {
        public static void Run()
        {
            var red = true;
            var yellow = false;
            var green = false;

            while (true)
            {
                Console.Clear();
                TrafficLightConsole.Show(red, yellow, green);
                if (red && !yellow)
                {
                    yellow = true;
                }
                else if (red)
                {
                    red = false;
                    yellow = false;
                    green = true;
                }
                else if (green)
                {
                    green = false;
                    yellow = true;
                }
                else if (yellow)
                {
                    yellow = false;
                    red = true;
                }

                Console.ReadKey(true);
            }
        }
    }
}