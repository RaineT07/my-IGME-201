using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_8
{
    //this program is designed to take every instance of the word 'no' and rewrite it to 'yes'
    //author: raine taber
    class Program
    {
        static void Main(string[] args)
        {
            //console asks user for input and stores it
            Console.Write("Please enter your input: ");
            string userInput = Console.ReadLine();
            //userInput is converted into an array of words
            string[] words = userInput.Split(' ');
            string result = "";
            foreach(string word in words)
            {
                //each word is checked for if it is 'no', and if it is? it's changed. if not, it's simply appended to the result string
                if (word == "no")
                {
                    result =result + " "+ "yes";
                }
                else
                {
                    result = result + " " + word;
                }

            }
            result.Trim();
            Console.Write(result);
        }
    }
}
