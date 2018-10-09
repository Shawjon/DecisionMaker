using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;

            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();

            while (yesNo == true)
            {           
                int x = 0;
                string xString;
                try
                {
                    Console.WriteLine(name + ", please enter a number between 1 and 100: ");
                    xString = Console.ReadLine();
                    x = int.Parse(xString);

                    if (x > 100)
                    {
                        Console.WriteLine("Sorry " + name + ", this number is above 100");
                        continue;
                    }
                    else if (x < 1)
                    {
                        Console.WriteLine("Sorry " + name + ", this number is below 1");
                        continue;
                    }
                    else if ((x % 2 == 1) & (x > 60))
                    {
                        Console.WriteLine(x + " and Odd ");
                    }
                    else if ((x % 2 != 1) & (x > 60))
                    {
                        Console.WriteLine(x + " and Even");
                    }
                    else if ((x % 2 != 1) & (x <= 60) & (x >= 26))
                    {
                        Console.WriteLine("Even");
                    }
                    else if ((x % 2 == 0) & (x <= 25) & (x >= 2))
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else
                    {
                        Console.WriteLine("Odd");

                    }
                }catch (FormatException)
                {
                    Console.WriteLine(name + ", that is not a valid input");
                }

                Console.WriteLine(name + ", would you like to continue? (y/n): ");
                var entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    yesNo = false;
                }


            }



        }
    }
}
