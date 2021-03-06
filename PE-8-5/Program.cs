using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_5
{
    //this program calculates the value of z, and stores x, y, and z in an array
    //Author: Raine Taber
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the array, array indexes, and values to be stored in said array
            double[,,] form = new double[21, 31, 3];
            int posX = 0;
            int posY = 0;
            double x = 0;
            double y = 0;
            double z = 0;
            //loop calculates the z value, and stores all data in the proper place
            for (x = -1; x <= 1; x = x+ 0.1, posX++)
            {
                x = Math.Round(x, 1);
                posY = 0;
                for (y = 1; y <= 4; y = y + 0.1, ++posY)
                {
                    y = Math.Round(y, 1);
                    z = ((3 * Math.Pow(y, 3)) + (2 * x) - 1);
                    z = Math.Round(z, 2);
                    form[posX, posY, 0] = x;
                    form[posX, posY, 1] = y;
                    form[posX, posY, 2] = z;
                    // debugging line: Console.WriteLine(x + " " + y + " " + z);
                }
              
            }

        }
    }
}
