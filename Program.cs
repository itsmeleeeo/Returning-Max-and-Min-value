using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1175WeekOneChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please digit a number");
            int num1 = Convert.ToInt32(ReadLine());

            WriteLine("Please digit the second number");
            int num2 = Convert.ToInt32(ReadLine());

            WriteLine("Please digit the third number");
            int num3 = Convert.ToInt32(ReadLine());

            WriteLine("Please digit the forth number");
            int num4 = Convert.ToInt32(ReadLine());

            WriteLine("The largest number is " + Math.Max(num1, Math.Max(num2, Math.Max(num3,num4))));
            WriteLine("The smallest number is " + Math.Min(num1, Math.Min(num2, Math.Min(num3,num4))));

            WriteLine("Press any key to close the console");
            ReadKey();
        }
    }
}
