using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE7_Mad_Libs
{
    //Author: Raine Taber
    //Description: Mad Libs
    //Caveats:if a sentence ends with a placeholder, there are always spaces between the placeholder and the ending punctuation.
    class Program
    {
        static void Main(string[] args)
        {
            //initialize number of libs, counter, and choice of lib variables, as well as the streamreader after
            int numLibs = 0;
            int counter = 0;
            int Choice = 0;

            StreamReader input;
            //initialize input to read in the madlibstemplate file
            input = new StreamReader("c:/templates/MadLibsTemplate.txt");

            //count lines in the file(each line is madlibs story)
            string line = null;
            while((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            //close input
            input.Close();

            //create an array with only the number of libs given
            string[] madLibs = new string[numLibs];

            //read the libs into the string array
            input = new StreamReader("c:/templates/MadLibsTemplate.txt");

            line = null;
            while((line = input.ReadLine()) != null)
            {
                madLibs[counter] = line;
                madLibs[counter] = madLibs[counter].Replace("\\n", "\n");
                ++counter;
            }
            input.Close();

            //prompt the user for which mad lib they want to play, and store it in Choice
            Console.Write("Which Lib do you want to play? " + numLibs + " Availible: ");
            bool isValid = false;
            while(!isValid)
            {
                string unparsedChoice = Console.ReadLine();
                isValid = int.TryParse(unparsedChoice, out Choice);
                if (!isValid || Choice>numLibs || Choice<=0) { Console.Write("Please input a valid number between 0 and " + numLibs + ":"); isValid = false; }
            }
            --Choice;

            //split the Lib into separate words, as well as put all the words together into one string
            string[] words = madLibs[Choice].Split(' ');
            string result = "";
            foreach (string word in words)
            {
                //this if statement checks if the word is a newline command, in which case is keeps the string from having unnecessary spaces in it
                //and continues to next loop without adding the word in twice by mistake.
                if (word != "\n")
                {
                    int wordSize = word.Length;
                    if (word.StartsWith("{"))
                    {
                        string paramWord = word.Replace('_', ' ');
                        Console.Write("Please enter a(n) " + paramWord.Substring(1, (word.IndexOf('}')-1)) + ": ");
                        string inputWord = Console.ReadLine();
                        inputWord = inputWord.ToLower();
                        inputWord = inputWord.Trim();
                        result = result + inputWord + " ";
                    }
                    else
                    {
                        result = result + word + " ";
                    }
                }
                else
                {
                    result = result + word;
                }
                
                
            }
            result.Trim();
            Console.Clear();
            Console.Write(result);
        }
    }
}
