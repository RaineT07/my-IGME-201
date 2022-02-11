using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Unit_test_1_4
{
    //program recreates the 3 questions exe, which has 2 questions from the monty python and the holy grail movie
    //and one from the hitchihkers guide to the galaxy book.
    //Author: Raine Taber
    class Program

    {
        static string answer; //stores user's answer
        static string[] correctAnswers = new string[] { "black", "42", "what do you mean? african or european swallow?" }; //stores the three correct answers
        static int nQuestion; //stores which quesiton the user wants to answer

        //initialize timeUp and timeOutTimer for use by the timer
        static bool timeUp = false;
        static Timer timeOutTimer;

        static void Main(string[] args)
        {

        //introduce start checkpoint so we can go back to it if the user wants to play again
        start:
            //ask user which question they want to answer
            bool bValid = false;
            while (!bValid)
            {
                Console.Write("Choose your question (1-3): ");
                bValid = int.TryParse(Console.ReadLine(), out nQuestion);
                if(nQuestion<1||nQuestion>3)
                {
                    bValid = false;
                }
            }

            //set up timer and delegate method/variable
            Console.WriteLine("You have 5 seconds to answer the following question:");
            timeOutTimer = new Timer(5000);
            ElapsedEventHandler elapsedEventHandler;
            elapsedEventHandler = new ElapsedEventHandler(TimesUp);
            timeOutTimer.Elapsed += elapsedEventHandler;
            timeUp = false;
            
            //switch for proper questioning
            switch (nQuestion)
            {
                case 1:
                    Console.WriteLine("What is your favorite color?");
                    break;
                case 2:
                    Console.WriteLine("What is the answer to the life, the universe and everything?");
                    break;
                case 3:
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    break;
            }
            //collect user input for answer
            timeOutTimer.Start();
            answer = Console.ReadLine();
            timeOutTimer.Stop();

            //if the user didn't run out of time, check if they got the right answer for the proper question
            if(!timeUp)
            {
                if (!answer.ToLower().Equals(correctAnswers[nQuestion - 1]))
                {
                    Console.WriteLine("Wrong! The answer is: " + correctAnswers[nQuestion - 1]);
                }
                else
                {
                    Console.WriteLine("Well done!");
                }
            }
            





            //ask the user if they want to play again. if they do, then go back to the start
            bool playNoMore = false;
            while(!playNoMore)
            {
                Console.Write("Play again?");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower().StartsWith("y"))
                {
                    goto start;
                }
                else if(playAgain.ToLower().StartsWith("n"))
                {
                    playNoMore = true;
                    return;
                }
            }
            
            
        }

        //Method: TimesUp
        //Delegate method called when timer is expired
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            //tell the user their time is up, stop the timer, and set timeup to true to detect time-outs
            Console.WriteLine("Time's up!");
            timeUp= true;
            timeOutTimer.Stop();
            //switch to give correct answer when timed out
            switch (nQuestion)
            {
                case 1:
                    Console.WriteLine("The answer is: " + correctAnswers[nQuestion-1]);
                    break;
                case 2:
                    Console.WriteLine("The answer is: " + correctAnswers[nQuestion-1]);
                    break;
                case 3:
                    Console.WriteLine("The answer is: " + correctAnswers[nQuestion-1]);
                    break;
            }
            Console.WriteLine("Please press enter. ");
        }

    }
}
