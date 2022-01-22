using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        
        static void Main(string[] args)
        {
           

            //given variables initialized
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            //my variables initialized
            bool isValid = false;
            double yStartInput=1.2;
            double yEndInput=-1.2;
            double xStartInput=-0.6;
            double xEndInput=1.77;
            //provide directions for input, and parse said input into yEndInput which is used
            //for the second clause of the first for-loop. this is done in this order
            //so instructions are easier for the user to follow while code is running.
            Console.Write("Please enter the first value. default for this value is -1.2. ");
            //parse user input for the yEndInput variable.
            while (!isValid)
            {
                isValid = double.TryParse(Console.ReadLine(), out yEndInput);
                if (!isValid) { Console.Write("Please input a number: "); }
                
            }
            isValid = false;
            //provide directions for second input, which is directed into yStartInput, the first clause of the first for-loop
            Console.Write("Please enter a second value larger than the first value. default for this value is 1.2. ");
            //parse user input for the yStartInput variable
            while(!isValid)
            {
                isValid = double.TryParse(Console.ReadLine(), out yStartInput);
                if (!isValid || yStartInput < yEndInput) { Console.Write("Please input a valid number"); }
            }
            isValid = false;
            //provide directions for third input, which is directed into xEndInput, the second clause of the second for-loop
            Console.Write("Please enter your third value, default for this value is 1.77. ");
            //parse user input for the xEndInput variable
            while (!isValid)
            {
                isValid = double.TryParse(Console.ReadLine(), out xEndInput);
                if (!isValid) { Console.Write("Please input a valid number"); }
            }
            isValid = false;
            Console.Write("Please enter a fourth value smaller than the third value. default for this value is -0.6. ");
            while (!isValid)
            {
                isValid = double.TryParse(Console.ReadLine(), out xStartInput);
                if (!isValid || xStartInput > xEndInput) { Console.Write("Please input a valid number"); }
            }

            //calculate the third clause for both for loops such that there is still 48 values in the first for-loop
            //and 80 values in the second for-loop
            double yInterval = (Math.Abs(yStartInput) + Math.Abs(yEndInput)) / 48;
            double xInterval = (Math.Abs(xStartInput) + Math.Abs(xEndInput)) / 80;
            //Console.WriteLine(xInterval);

            for (imagCoord = yStartInput; imagCoord >= yEndInput; imagCoord -= yInterval) 
            {
                for (realCoord = xStartInput; realCoord <= xEndInput; realCoord += xInterval)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}