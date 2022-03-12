﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Raine Taber
//program changes Friend from a struct to a class, and makes the adjustments in Main() accordingly
namespace Unit_test_2_Q_14
{
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            //make a hard copy of enemy using friend's data
            enemy.name = friend.name;
            enemy.greeting = friend.greeting;
            enemy.birthdate = friend.birthdate;
            enemy.address = friend.address;

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }

}
