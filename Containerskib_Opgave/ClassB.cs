using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerskib_Opgave
{
    internal class ClassB
    {
        public double input;

        public ClassB()
        {

        }

        private double Knob { get; set; }

        public double KnobTilKmt(double knob)
        {
            input = knob;
            return knob * 1.85;
        }

        public double KmtTilKnob(double km)
        {
            input = km;
            return km / 1.85;
        }
    }
}
