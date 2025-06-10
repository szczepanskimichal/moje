using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightDemo;

namespace TrafficLight
{
    internal class TrafficLight
    {
        public bool Red;
        public bool Yellow;
        public bool Green;
        
        public void show()
        {
            TrafficLightConsole.Show(Red, Yellow, Green);
        }
    
        public void GoToNextPhase()
        {
            if (Red && !Yellow)
            {
                Yellow = true;
            }
            else if (Red)
            {
                Red = false;
                Yellow = false;
                Green = true;
            }
            else if (Green)
            {
                Green = false;
                Yellow = true;
            }
            else if (Yellow)
            {
                Yellow = false;
                Red = true;
            }
        }
    
    }


}
