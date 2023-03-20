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

            // convert string to Int, and used for arithmetic operation
            string Agatha = "20";
            int Abiola = 40;
            int Uche = Convert.ToInt16(Agatha);            
            Console.WriteLine($"The Number Jackline is {Uche + Abiola}");
            DateTime Dami = DateTime.UtcNow;
            DateTime faridah = DateTime.Now;
            if (Dami >= faridah)
            {
                Console.WriteLine("Good Afternoon");
            }
            else { Console.WriteLine("Good Night"); }

            Console.WriteLine("The Number Jackline is " + Jackline);
            Console.WriteLine($"The Number Jackline is {Jackline} + {mariam}");
            Console.WriteLine($"The Number Jackline is {Jackline + mariam}");
            Console.WriteLine($"{faith} is {mariam - precious}");
            Console.WriteLine($"{faith} is {mariam == precious}");
            Console.WriteLine($"{faith} is {Dami}");

            // Salutation based on current time (hour) in UTC
            string Salutation;
            if (DateTime.UtcNow.Hour >= 0 && DateTime.UtcNow.Hour < 11)
            {
                Salutation = "Bonjour";
            }
            else if (DateTime.UtcNow.Hour >= 11 && DateTime.UtcNow.Hour < 15)
            {
                Salutation = "Bonsoir";
            }
            else if (DateTime.UtcNow.Hour >= 15 && DateTime.UtcNow.Hour < 20)
            {
                Salutation = "Salut";
            }
            else
            {
                Salutation = "Allô";
            }
            Console.WriteLine(Salutation);

            // shorthand method of if/else 
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";  // if else       
            Console.WriteLine(result);

            // same as above
            int time2 = 20;
            string result2;
            if (time2 < 18) // if else 
            {
                result2 = "Good day.";
            }
            else
            {
                result2 = "Good evening.";
            }
            Console.WriteLine(result2);

            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            // Like I told you in class, you'll get more at w3schools
        }
    }
}
