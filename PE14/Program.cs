using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    //author: raine taber
    //display my grasp of class objects and inheritance with interfaces.

    //basic interface with method MathItUp()
    public interface IClassy
    {
        void MathItUp();
    }

    //classier class that inherits from IClassy and computes 2+2 for its MathItUp() method (also has a line in constructor to tell user that the object was properly created
    public class classier : IClassy
    {
        public void MathItUp()
        {
            Console.WriteLine($"what's 2+2? {2 + 2}");
        }
        public classier()
        {
            Console.WriteLine("classier object made");
        }
    }

    //classiest class that inherits from IClassy and computes 4+4 for its MathItUp() method (also has a line in constructor to tell user that the object was properly created
    public class classiest:IClassy
    {
        public void MathItUp()
        {
            Console.WriteLine($"what's 4+4? {4 + 4}");
        }
        public classiest()
        {
            Console.WriteLine("classiest object made");
        }
    }
    //program creates 2 objects, one of classier class and one of classiest class. then, MyMethod is called 3 times,
    ////once with the classier class as a parameter, once with the classiest class as the param, and once with a string as the param.
    class Program
    {
        static void Main(string[] args)
        {
            classier myClassierClass = new classier();
            classiest myClassiestClass = new classiest();
            MyMethod(myClassierClass);
            MyMethod(myClassiestClass);
            MyMethod("start");
        }
        //MyMethod() attempts to convert the given parameter to an IClassy object, and prints "not an IClassy object" if the parameter does not inherit from IClassy
        public static void MyMethod(object myObject)
        {
            IClassy myClassy = null;
            try
            {
                myClassy = (IClassy)myObject;
                myClassy.MathItUp();
            }
            catch
            {
                Console.WriteLine("not an IClassy object");
            }
        }
    }
}
