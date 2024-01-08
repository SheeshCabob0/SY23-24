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
            Console.WriteLine("Please input a number");
            int.TryParse(Console.ReadLine(), out num);
            Console.Write("Your number is " + num + ", multiplied by 2 equals " + num * 2);
            Console.ReadLine();
        }
    }
}
