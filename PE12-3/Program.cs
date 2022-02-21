using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_3
    //Author: Raine Taber
    //application has two classes, MyClass and MyDerivedClass, both are used
    //to demonstrate my understanding of how classes and class members function
{
    //holds one field, myString, and has a virtual GetString method which returns myString, as well as a property that can set myString if needed.
    public class MyClass
    {
	    private string myString;
        public virtual string GetString()
        {
            return this.myString;
        }
        public string MyString
        {
            set
            {
                myString = value;
            }
        }

    }
    //class inherits from MyClass, and overrides the GetString method of MyClass.
    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            string overridden;
            overridden = base.GetString() + " (output from the derived class)" ;
            return overridden;
        }
    }

    class Program
    {
        //asks the user to input something for an instance of MyDerivedClass's getstring field, and uses the instance's getstring to output.
        static void Main(string[] args)
        {
            MyDerivedClass derived = new MyDerivedClass();
            Console.Write("Please enter myString for the derived class: ");
            derived.MyString = Console.ReadLine();
            Console.WriteLine(derived.GetString());
        }
    }
}
