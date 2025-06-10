using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    internal class TrafficLightDemo2
    {
        public static void Run()
        {
            var trafficLight = new TrafficLight();
            while (true)
            {
                Console.Clear();
                trafficLight.show();
                Console.ReadKey(true);
                trafficLight.GoToNextPhase();
            }
        }
    }
}
