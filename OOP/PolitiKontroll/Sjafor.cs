using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitiKontroll
{
    internal class Sjafor
    {
      

        public string Name { get; set; }
        public bool Seatbelt { get; set; }
        public bool UsesPhone { get; set; }
        public bool DriverLicense { get; set; }
        public double Alko { get; set; }
        public int Speed { get; set; }

        // Konstruktor!!!
  public Sjafor(string name, bool seatbelt, bool usesPhone, bool driverLicense, double alko, int speed)
        {
            Name = name;
            Seatbelt = seatbelt;
            UsesPhone = usesPhone;
            DriverLicense = driverLicense;
            Alko = alko;
            Alko = speed;
        }

    }
}
