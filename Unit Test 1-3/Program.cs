using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_1_3
{
    //program asks for two numbers, and how many places you'd like your quotient to be rounded to
    //Author: Raine Taber

    //initializing a delegate data type
    delegate double RoundingDataType(double d, int i);
    class Program
    {
        //creating a delegate function
        static double Round(double d, int i)
        {
            double rounded = Math.Round(d, i);

            return rounded;
        }
        
        static void Main(string[] args)
        {
            bool bValid = false;
            //creating our delegate variable
            RoundingDataType round = new RoundingDataType(Round);
            
            //following code asks the user for the number to be divided by and checks if it's a valid input
            Console.Write("number division! \n \n select one number to divide: ");
            
            double dFirstNum=0;
            while (!bValid)
            {
                string firstNum = Console.ReadLine();
                bValid = double.TryParse(firstNum, out dFirstNum); 
                if(!bValid)
                {
                    Console.Write("Please enter a valid Number: ");
                }
            }
            //following code asks the user for the number to divide by, and checks if its a valid input
            bValid = false;
            Console.Write("\n select a number to divide that by: ");
            double dSecondNum=0;
            while (!bValid)
            {
                string secondNum = Console.ReadLine();
                bValid = double.TryParse(secondNum, out dSecondNum);
                if(!bValid)
                {
                    Console.Write("Please enter a valid Number: ");
                }
            //following code asks for the amount of places the user would like to round to
            }
            bValid = false;
            Console.Write("\n how many places would you like to round to? ");
            int rounder=0;
            while(!bValid)
            {
                string thirdNum = Console.ReadLine();
                bValid = int.TryParse(thirdNum, out rounder);
                if(!bValid)
                {
                    Console.Write("Please enter a valid non-decimal number: ");
                }
            }
            //implementing the lambda operator to round two numbers.
            round = (double d, int i) =>
            {
                return Math.Round(d, i);
            };
            dFirstNum = round(dFirstNum, 5);
            dSecondNum = round(dSecondNum, 5);
            
            //divides user input, and calls the delegate method to properly round it
            double finalAnswer = 0;
            finalAnswer = round((dFirstNum / dSecondNum), rounder);
            Console.WriteLine("your quotient is " + finalAnswer);
        }
    }
}
