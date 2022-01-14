using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            //declare int counter
            //int i = 0 syntax error - missing semicolon
            int i = 0;

            string allNumbers = null;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) runtime error - this loop only goes from values 1-9
            for (i = 1; i <= 10; ++i)
            {

            // declare string to hold all numbers
            //string allNumbers = null; logic error - this variable should be initiated outside of the for loop

            // output explanation of calculation
            //Console.Write(i + "/" + i - 1 + " = "); syntax error - missing $ to allow code blocks in strings, missing code block to process 
            Console.Write("" + i+ $"/  {i - 1}  = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1)); runtime error - this causes a divide-by-zero error
                double DoubleI = Convert.ToDouble(i);
                Console.WriteLine(DoubleI / (DoubleI - 1.0));

            // concatenate each number to allNumbers
            //allNumbers += i + " ";

            // increment the counter
            //i = i + 1; logic error - there is no need to increment the counter, its done automatically in the for loop
            Console.Write(i);
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); syntax error - missing + operator to add allNumbers to the line written
            //Console.WriteLine("These numbers have been processed: " + allNumbers);

        }
    }
}
