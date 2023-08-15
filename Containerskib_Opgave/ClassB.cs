using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerskib_Opgave
{
    internal class ClassB
    {
        
        public ClassB()
        {

        }

        public double KnobTilKmt(double knob)
        {
            return knob * 1.85;
        }

        public double KmtTilKnob(double km)
        {
            return km / 1.85;
        }
    }
}
