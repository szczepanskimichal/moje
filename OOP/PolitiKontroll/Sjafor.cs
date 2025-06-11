using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitiKontroll
{
    public class Sjafor
    {
        public string Name { get; set; }
        public bool Seatbelt { get; set; }
        public bool UsesPhone { get; set; }
        public bool DriverLicense { get; set; }
        public double AlcoholLevel { get; set; } // promille
        public int Speed { get; set; } // km/t

        public Sjafor(string name, bool seatbelt, bool usesPhone, bool driverLicense, double alcoholLevel, int speed)
        {
            Name = name;
            Seatbelt = seatbelt;
            UsesPhone = usesPhone;
            DriverLicense = driverLicense;
            AlcoholLevel = alcoholLevel;
            Speed = speed;
        }
    }
}
