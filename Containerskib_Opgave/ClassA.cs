using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerskib_Opgave
{
    internal class ClassA
    {
        // Field
        ClassB classB;

        public ClassA()
        {
            //Initialize field
            classB = new ClassB();

            Menu();
        }        

        public void Menu()
        {
            int menuIndtast;
            do
            {
                double inputDouble = -1;
                Console.WriteLine("Menu");
                Console.WriteLine("Tast 1. for at beregne km/t til knob");
                Console.WriteLine("Tast 2. for at beregne knob til km/t");
                Console.WriteLine("Tast 0. for at lukke programmet");

                //Denne her linje sørger for at så længe at der bliver indtastet tegn, så vil den gå i en løkke indtil man
                //indtaster et tal som er inden for 0-2.
                while (!int.TryParse(Console.ReadLine(), out menuIndtast) || menuIndtast > 2 || menuIndtast < 0) ;

                if (menuIndtast == 1)
                {
                    Console.Write("Indtast et input i tal for at få et resultat: ");
                    //Linjen nedenunder er et eksempel på hvordan jeg kunne bruge TryParse til at få et double resultat
                    //uden at tegn ville give problemmer.
                    /* while (!double.TryParse(Console.ReadLine(), out inputDouble)) ; */
                    inputDouble = StringProof();
                    KmTilKnots(inputDouble);
                }

                else if (menuIndtast == 2)
                {
                    Console.Write("Indtast et input i tal for at få et resultat: ");
                    inputDouble = StringProof();
                    KnotsTilKm(inputDouble);
                }

                else if (menuIndtast == 0) { }

                Console.ReadKey();
                Console.Clear();
            } while (menuIndtast != 0);
        }

        public void KmTilKnots(double km)
        {
            var result = classB.KmtTilKnob(km);
            Console.WriteLine("Dette er resultatet beregnet fra km/t til knob: " + Math.Round(result, 2));
        }

        public void KnotsTilKm(double knots)
        {
            var result = classB.KnobTilKmt(knots);
            Console.WriteLine("Dette er resultatet beregnet fra knob til km/t: " + Math.Round(result, 2));
        }

        public double StringProof()
        {
            double inputDouble;
            while (!double.TryParse(Console.ReadLine(), out inputDouble) || inputDouble <= 0)
            {
                Console.WriteLine("Skal være mere end 0 og et tal");
            }
            return inputDouble;
        }
    }
}
