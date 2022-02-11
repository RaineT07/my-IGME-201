using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_test_1_13
{
    class Program
    {
    
        //this program prompts the user for their name, and increases their salary if their name is the same as the Author's name
        //Author: Raine Taber


        //create struct employee and constructor
        public struct employee
        {
            public string sName;
            public double dSalary;
            public employee(string name, double salary)
            {
                this.sName = name;
                this.dSalary = salary;
            }
        }

        static void Main(string[] args)
        {
            //prompt the user for their name
            Console.Write("what is your name? ");
            string tempName = Console.ReadLine();

            //create an employee structure with the user's name and 30000 as the salary
            employee newEmploy = new employee(tempName, 30000);

            //if statement calls the giveRaise method, and then 
            //outputs wether or not the user got a raise.

            if (GiveRaise(ref newEmploy))
            {
                Console.WriteLine("Congratulations " + newEmploy.sName + ", you have earned a raise! Your new salary is: $" + newEmploy.dSalary);
            }
            else
            {
                Console.WriteLine("Tough luck.");
            }

        }

        //GiveRaise: checks if the employee structure's sName is the same as the Author's name (Raine Taber) and gives them a raise if so,
        //before returning true or false based on if the user's name is the same.
        static bool GiveRaise(ref employee e)
        {
            if (e.sName.Equals("Raine Taber"))
            {
                e.dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

