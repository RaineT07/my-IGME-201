using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raine R. Taber");
            String myName = "Raine R. Taber";
            Console.WriteLine(myName + "" + 6);
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(myName + " " + x);
                Console.WriteLine("nice to meet you!");
            }
        }
    }
}
