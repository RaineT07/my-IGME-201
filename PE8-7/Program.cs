using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_7
{
    //this program takes a user's input and writes it to console backwards
    //Author: Raine Taber
    class Program
    {
        static void Main(string[] args)
        {
            //variables for original and changed input are established
            string originalInput;
            string reverseInput = "";
            //input is asked for and stored
            Console.Write("please input here: ");
            originalInput = Console.ReadLine();
            //this for loop starts at the equivalent number of the last character in a string
            //and takes every character from last, to first, rewriting it into the changed input variable
            for(int x=originalInput.Length-1; x>=0;x--)
            {
                reverseInput = reverseInput + "" + originalInput[x];
            }
            Console.WriteLine(reverseInput);
            
        }
    }
}
