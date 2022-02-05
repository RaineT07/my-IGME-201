using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_3
{
    class Program
    {
        delegate string InputReader();

        static string GetInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        static void Main(string[] args)
        {
            InputReader userInput;
            userInput = new InputReader(GetInput);
            string sName = userInput();
        }
    }
}
