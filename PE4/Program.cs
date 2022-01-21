using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaring start case in the event that both numbers are less or both numbers are more than 10
            start:
            //declare the 2 input variables as 0 as well as valid input boolean
            int firstInput = 0;
            int secondInput = 0;
            bool isValid = false;
            //prompting user for input, storing it in firstInput
            Console.Write("Enter your first number: ");
            while (!isValid)
            {
                //parses user input to detect if number inputted
                isValid = int.TryParse(Console.ReadLine(), out firstInput);
                if (!isValid) { Console.Write("Please enter a number: "); }
            }
            //resetting isValid, prompting user for input again, storing in secondInput
            isValid = false;
            Console.Write("Enter your second number: ");
            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out secondInput);
                if (!isValid) { Console.Write("Please enter a number: "); }
            }
            //declaring and setting proper values to operand1 and operand2
            bool operand1 = firstInput > 10;
            bool operand2 = secondInput > 10;
            //testing to see if operand1 and 2 are exclusive to each other
            if(operand1^operand2)
            {
                //writes valid result
                Console.Write("result valid! input one: " + firstInput + " input two: " + secondInput);
                
            }
            else
            {
                //tells you result is invalid, code wraps back to start
                Console.WriteLine("invalid result!");
                goto start;
            }
        }
    }
}
