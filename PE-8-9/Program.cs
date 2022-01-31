using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_9
{
    //this program takes any string of words and puts quotation marks around it
    //author: Raine Taber
    class Program
    {
        static void Main(string[] args)
        {
            //asking for user input
            Console.Write("Please enter your input: ");
            string userInput = Console.ReadLine();
            //userInput is converted into an array of words
            string[] words = userInput.Split(' ');
            string result = "";
            //using a constant string quote with the " character
            const string mark = "\"";
            foreach (string word in words)
            {
                result = result + " " + mark + word + mark;
            }
            result.Trim();
            Console.Write(result);
        }
    }
}
