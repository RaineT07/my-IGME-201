using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalInput;
            string reverseInput = "";
            Console.Write("please input here: ");
            originalInput = Console.ReadLine();
            for(int x=originalInput.Length-1; x>=0;x--)
            {
                reverseInput = reverseInput + "" + originalInput[x];
            }
            Console.WriteLine(reverseInput);
            
        }
    }
}
