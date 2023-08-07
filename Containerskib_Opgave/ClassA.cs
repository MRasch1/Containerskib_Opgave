using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerskib_Opgave
{
    internal class ClassA
    {
        ClassB classB = new ClassB();



        public ClassA()
        {
            Console.Write("Indtast et input i tal for at få et resultat: ");
            classB.input = Convert.ToDouble(Console.ReadLine());
            classB.KnobTilKmt(classB.input);
            classB.KmtTilKnob(classB.input);
            Console.WriteLine("Dette er resultatet beregnet fra knob til km/t: " + Math.Round(classB.km, 2));
            Console.WriteLine("Dette er resultatet beregnet fra km/t til knob: " + Math.Round(classB.knob, 2));
            Console.ReadKey();
        }

    }
}
