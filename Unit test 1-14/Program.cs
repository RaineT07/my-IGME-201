using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY compile time error. missing semicolon
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); compile-time error, this line does not actually contain a string to write.
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); logic error, this readline doesn't actually store anything, and it causes the error in tryParse in the next line
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                //} while (int.TryParse(sNumber, out nX)); runtime error. this tryParse method writes sNumber into the wrong variable. it causes the compiler error message on line 33.
                //this line also has another runtime error, because the loop will never exit due to the condition being reliant on a true TryParse result.
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); run-time error. missing the $ operator in the written string, so you will get the incorrect output.
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }


        //int Power(int nBase, int nExponent) compile-time error, this method is not static so it causes an error on line 34, because it cannot be called in Main
        static int Power(int nBase, int nExponent)

        {
            Console.WriteLine($"nBase: {nBase}, nExponent: {nExponent}");
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; //logic error. this will cause the recursion to fail and give you the result nBase^1
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); runtime error, this line causes the method to recurse, and therefor a stack overflow exception error is thrown during runtime.
                nextVal = Power(nBase, (nExponent - 1));

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            //returnVal; compile-time error, this line doesn't actually return returnVal, which causes an error in line 34.
            return returnVal;
        }
    }
}
