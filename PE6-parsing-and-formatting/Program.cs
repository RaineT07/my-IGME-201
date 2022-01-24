using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_parsing_and_formatting
{
    class Program
    {
        //Author: Raine Taber
        //Purpose: ask the user for a number of guesses, and let a user guess a random number
        //for the set amount of times they asked for.
        //known caveats: none that I'm aware of.
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            //randomNumber: holds the number the user has to guess
            //numAttempts: holds the amount of attempts the user inputs
            //currentGuess: self explanatory
            //guessedCorrectly: setup for an if-statement that triggers the losing message.
            //essentially makes sure that the losing message is only written when the player runs out of guesses
            int randomNumber = rand.Next(0, 101);
            int numAttempts;
            int currentGuess;
            bool guessedCorrectly = false;

            //writes the number the user wants to guess
            Console.WriteLine(randomNumber);

            //asks the user for an amount of attempts, and only accepts the input if the input is valid
            Console.Write("please enter a number of attempts to guess the number: ");
            numAttempts = IsGoodInput(Console.ReadLine());

            //loop runs numAttempts times
            for(int x=1; x<numAttempts+1;x++)
            {
                //tells user their turn number, and prompts them to guess
                Console.Write("turn #" + x + ": Enter your guess: ");
                currentGuess = IsGoodInput(Console.ReadLine());

                //if statement tells user wether the guess is too high or low, and if it is
                //the correct number, it'll write out the win dialogue
                if(currentGuess>randomNumber)
                {
                    Console.WriteLine("Too high");
                    continue;
                }
                else if(currentGuess<randomNumber)
                {
                    Console.WriteLine("Too low");
                    continue;
                }
                else
                {
                    if (currentGuess==1)
                    {
                        Console.WriteLine("Correct! You guessed it in one try. excellent job!.");
                        guessedCorrectly = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Correct! You won in " + x + " turns.");
                        guessedCorrectly = true;
                        break;
                    }
                }
            }
            
            //should the correct number not be guessed, this if statement runs instead of the winning else statement
            if(guessedCorrectly==false)
            {
                Console.WriteLine("You ran out of turns. The number was " + randomNumber);
            }

        }

        //this method checks to see if the input from the user is a valid integer. 
        //it takes one string, which is the user input. then it trims is, parses it, 
        //and returns it if it's valid. if not, it prompts the user to enter a different input.
        static int IsGoodInput(string paramInput)
        {
            string input = paramInput;
            input = input.Trim();
            int parsedInput = 0;
            bool isValid = false;
            while(!isValid)
            {
                isValid = int.TryParse(input, out parsedInput);
                if (!isValid)
                {
                    Console.Write("please input a non-decimal number: ");
                    input = Console.ReadLine();
                }
            }
            return parsedInput;
        }
    }
}
