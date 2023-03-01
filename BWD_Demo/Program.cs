using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWD_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Jackline = 5;
            Jackline = 2 + 2;
            int mariam = 8;
            var precious = 9;
            string faith = "abiodun";
            DateTime Dami = DateTime.UtcNow;
            DateTime faridah = DateTime.Now;
            if (Dami >= faridah)
            {
                Console.WriteLine("Good Afternoon");
            }
            else { Console.WriteLine("Good Night"); }

            //Console.WriteLine("The Number Jackline is " + Jackline);
            //Console.WriteLine($"The Number Jackline is {Jackline} + {mariam}");
            //Console.WriteLine($"The Number Jackline is {Jackline + mariam}");
            //Console.WriteLine($"{faith} is {mariam - precious}");
            //Console.WriteLine($"{faith} is {mariam == precious}");
            //Console.WriteLine($"{faith} is {Dami}");
        }
    }
}
