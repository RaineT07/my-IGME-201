using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_1_3
{
    delegate double RoundingDataType(double d, int i);
    class Program
    {
        static double Round(double d, int i)
        {
            double rounded = Math.Round(d, i);

            return rounded;
        }
        
        static void Main(string[] args)
        {
            bool bValid = false;
            RoundingDataType round = new RoundingDataType(Round);
            
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
            round = (double d, int i) =>
            {
                return Math.Round(d, i);
            };
            dFirstNum = round(dFirstNum, 5);
            dSecondNum = round(dSecondNum, 5);
            
            
            double finalAnswer = 0;
            finalAnswer = round((dFirstNum / dSecondNum), rounder);
            Console.WriteLine("your quotient is " + finalAnswer);
        }
    }
}
