using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taber_PE3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 4 variables to store user input

            int firstInput = 0;
            int secondInput = 0;
            int thirdInput = 0;
            int fourthInput = 0;

            // create a loop control variable isValid
            bool isValid = false;
            //grab and parse the first number
            Console.WriteLine("Enter your first number!");
            while(!isValid)
            {
                //check if input is parse-able as an int
                isValid = int.TryParse(Console.ReadLine(), out firstInput);
                //if not parse-able, ask to enter a number until a valid input is achieved
                if (!isValid) {Console.Write("Please enter a number: "); };
            }
            //repeat code 2nd time
            isValid = false;
            Console.WriteLine("Enter your second number!");
            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out secondInput);
                if (!isValid) { Console.Write("Please enter a number: "); };
            }
            //repeat code 3rd time
            isValid = false;
            Console.WriteLine("Enter your third number!");
            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out thirdInput);
                if (!isValid) { Console.Write("Please enter a number: "); };
            }
            //repeat code 4th time
            isValid = false;
            Console.WriteLine("Enter your final number!");
            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out fourthInput);
                if (!isValid) { Console.Write("Please enter a number: "); };
            }
            //create product variable
           int product = firstInput * secondInput * thirdInput * fourthInput;
            //output the product to console
            Console.WriteLine("Your product is " + product);
            //for some reason whenever I enter the last input, it instantly closes the
            //console. to prevent this, I have added an extra readline command so that the
            //console only closes when enter is hit after the product is displayed
            string temp = Console.ReadLine();
        }
    }
}
