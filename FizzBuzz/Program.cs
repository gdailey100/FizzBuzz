using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // This runs the Fizz Buzz program without user entering anthing
            for (int i = 1; i <= 10000; i++)
            {
                // To speed up the program I have used 15 
                if ((i % 15 == 0) )
                {
                    // Print results
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    // Print results
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    // Print results
                    Console.WriteLine(i + " Buzz");
                }
                // Print results
                else Console.WriteLine(i);
            }

        }
    }
}
