using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
namespace PE9_2
{
    class Program
    {
        //initialize timeOut flag(Raine's Code)
        static bool timeOut = false;
        //timer for timeOut
        static Timer timeOutTimer;
        static void Main()
        {
            // store user name
            string myName = "";

            // string and int of # of questions
            string sQuestions = "";
            int? nQuestions = null;

            // string and base value related to difficulty
            string sDifficulty = "";
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            int nAnswer = 0;

            // string and int for the response
            string sResponse = "";
            Int32 nResponse;

            // boolean for checking valid input
            bool bValid;

            // play again?
            string sAgain = "";

            // seed the random number generator
            Random rand = new Random();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while (true)
            {
                // prompt for their name
                Console.Write("What is your name-> ");


                // read myName from the console
                myName = Console.ReadLine();

                // leave the loop if they entered something
                // strings can check equivalency
                //if( myName == "david")
                // string cannot check for less than/greater than using the symbols
                //if( myName > "" )
                //if( myName.CompareTo("") > 0)
                if (myName.Length > 0)
                {
                    break;
                }
            }

        // label to return to if they want to play again
        start:

            // initialize correct responses for each time around
            nCorrect = 0;

            

            Console.WriteLine();

            // fetch how many questions they want into nQuestions
            while (nQuestions == null)
            {
                Console.Write("How many questions-> ");

                int localnQuestions = 0;
                if (int.TryParse(Console.ReadLine(), out localnQuestions))
                {
                    nQuestions = localnQuestions;
                }
            }

            Console.WriteLine();


            // fetch the difficulty level (easy, medium or hard) into sDifficulty
            do
            {
                Console.Write("Difficulty level (simple, easy, medium, hard)-> ");

                sDifficulty = Console.ReadLine();

            } while (sDifficulty.ToLower() != "simple" &&
                     sDifficulty.ToLower() != "easy" &&
                     sDifficulty.ToLower() != "medium" &&
                     sDifficulty.ToLower() != "hard");

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty.ToLower())
            {
                case "simple":
                case "easy":
                    nMaxRange = MAX_BASE;

                    if (myName.ToLower() == "david")
                    {
                        goto case "hard";
                    }
                    break;

                case "medium":
                    nMaxRange = MAX_BASE * 2;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE * 3;
                    break;
            }

            // ask each question
            for (nCntr = 0; nCntr < nQuestions; ++nCntr)
            {

                //set nResponse to 0 every time
                nResponse = 0;

                //initialize bValid to false to start
                bValid = false;

                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);

                // pick 2 random numbers based on the difficulty
                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers
                if (val1 == 0 || val2 == 0)
                {
                    // decrement counter to try this one again (because it will be incremented at the top of the loop)
                    --nCntr;
                    continue;
                }

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // else multiplication
                // generate nAnswer and the sQuestion string
                if (nOp == 0)
                {
                    nAnswer = val1 + val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} + {val2} => ";
                }
                else if (nOp == 1)
                {
                    nAnswer = val1 - val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} - {val2} => ";
                }
                else
                {
                    nAnswer = val1 * val2;
                    sQuestions = $"Question #{nCntr + 1}: {val1} * {val2} => ";
                }




                //set the timeOut timer to 5 seconds
                timeOutTimer = new Timer(5000);

                //declare delegate elapsedEventhandler
                ElapsedEventHandler elapsedEventHandler;

                //point the variable to the timesUp method
                elapsedEventHandler = new ElapsedEventHandler(TimesUp);

                //add timesUp() to timeOutTimer.elapsed event handler
                timeOutTimer.Elapsed += elapsedEventHandler;
                timeOut = false;



                // display the question and prompt for the answer using sResponse and nResponse to store their response
                timeOutTimer.Start();
                    while (bValid == false&&!timeOut)
                    {
                        Console.Write(sQuestions);
                        sResponse = Console.ReadLine();

                        try
                        {
                            nResponse = int.Parse(sResponse);
                            bValid = true;
                        }
                        catch
                        {
                            Console.WriteLine("Please enter an integer.");
                            bValid = false;
                        }
                    }
                timeOutTimer.Stop();









                // if nResponse == nAnswer, output flashy reward and increment # correct
                // else output stark answer
                        if (nResponse == nAnswer&&!timeOut)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Well done, {0}!!!", myName);

                            ++nCorrect;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("I'm sorry {0}. The answer is {1}", myName, nAnswer);
                        timeOut = true;
                        }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            Console.WriteLine();

            // output how many they got correct (nCorrect) and their score
            Console.WriteLine("You got {0} correct out of {1}, which is a score of {2:P2}", nCorrect, nQuestions, Convert.ToDouble(nCorrect) / (double)nCntr);

            Console.WriteLine();


            // ask if they want to play again
            do
            {
                // prompt if they want to play again
                Console.Write("Do you want to play again? ");

                sAgain = Console.ReadLine();

                if (sAgain.ToLower().StartsWith("y"))
                {
                    goto start;
                }
                else if (sAgain.ToLower().StartsWith("n"))
                {
                    break;
                }
            } while (true);
        }

        //Method: TimesUp
        //purpose: Delegate method called when timer is expired
        //restrictions: none
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");
            //set timeOut to true to end time for particular question
            timeOut = true;
            
            //stop the timer
            timeOutTimer.Stop();
        }

    }
}
