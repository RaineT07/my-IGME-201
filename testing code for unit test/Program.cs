using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_code_for_unit_test
{
    public sealed class Circus
    {
        public string name;
    }


    static class Program
    {
        static void Main()
        {

            SortedList<(double, double, double), double> formulaList = new SortedList<(double, double, double), double>();

            for(double w = -2; w<=0; w+=0.2)
            {
                w = Math.Round(w, 1);
                for(double x=0; x<= 4; x+=0.1)
                {
                    x = Math.Round(x, 1);
                    for(double y=-1; y<=1; y+=0.1)
                    {
                        y = Math.Round(y, 1);
                        double z = ((4 * Math.Pow(y, 3)) + (2 * Math.Pow(x, 2)) - (8 * w) + 7);
                        z = Math.Round(z, 3);
                        formulaList[(w, x, y)] = z;
                    }
                }
            }
        }
    }

}
