using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //the \t is optional
            Console.WriteLine("\t" + "Enter the number of liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);


            Console.WriteLine();
            Console.WriteLine("Press to convert liters into \n 1 for fl oz \n 2 for gi \n 3 for pt \n 4 for qt \n 5 for gal \n 6 for tbsp \n 7 for tsp \n 8 for cups");
            int.TryParse(Console.ReadLine(), out num);

            //switch statement num == case

            switch (num)
            {
                case 1: 
                    Console.Write("\t" + liters * 33.814 + " fl oz");
                    break;
                case 2:
                    Console.Write("\t" + liters * 8.45351 + " gill(s)");
                    break;
                case 3:
                    Console.Write("\t" + liters * 2.11338 + " pint(s)");
                    break;
                case 4:
                    Console.Write("\t" + liters * 1.05669 + " quart(s)");
                    break;
                case 5:
                    Console.Write("\t" + liters * 0.264172 + " gallon(s)");
                    break;
                case 6:
                    Console.Write("\t" + liters * 67.628 + " tbsp");
                    break;
                case 7:
                    Console.Write("\t" + liters * 202.884 + " tsp");
                    break;
                case 8:
                    Console.Write("\t" + liters * 4.16667 + " cup(s)");
                    break;
               
                default:
                    Console.WriteLine("Invalid Units!");
                    break;
            }

            //wait for user input to close the program
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }
    }
}
