using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IntroUnitTesting
{
    internal class Stats
    {
        public int Count { get; private set; } = 0;
        public int Sum { get; private set; } =  0;
        public int Max { get; private set; } = 0;
        public int Min { get; private set; } = 0;
        public float Mean => (float)Sum / Count;

        public void Add(int number)
        {
            if(Max == -1 || number > Max) Max = number;
            if (Min == -1 || number < Min) Min = number;
            Count++;
            Sum += number; 
        }
        public string GetDescription()
        {
            return
                Format("antall tall", Count) +
                Format("sum", Sum) +
                Format("Max", Max) +
                Format("Min", Min) +
                Format("Gjennomsnitt", Mean);

                
        }
        private static string Format(string label, float number)
        {
            return FormatImpl(label, number.ToString("####.##"));
            
        }
        private static string Format(string label, int number)
        {
            return FormatImpl(label, number.ToString("####"));
        }

        private static string FormatImpl(string label, string number)
        {
            return label.PadRight(12, ' ')
                + ": "
                + number
                + '\n';
        }
    }
}
