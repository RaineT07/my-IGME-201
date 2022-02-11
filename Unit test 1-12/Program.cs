using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_test_1_12
{
    class Program
    {
        //this program prompts the user for their name, and increases their salary if their name is the same as the Author's name
        //Author: Raine Taber




        static void Main(string[] args)
        {
            //prompt the user for their name
            Console.Write("what is your name? ");
            string sName = Console.ReadLine();
            double dSalary = 30000;


            //if statement calls the giveRaise method, and then 
            //outputs wether or not the user got a raise.

            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congratulations " + sName + ", you have earned a raise! Your new salary is: $" + dSalary);
            }
            else
            {
                Console.WriteLine("Tough luck.");
            }

        }

        //GiveRaise: checks if the employee name is the same as the Author's name (Raine Taber) and gives them a raise if so,
        //before returning true or false based on if the user's name is the same.
        static bool GiveRaise(string name, ref double salary)
        {
            if (name.Equals("Raine Taber"))
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
