using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_code_for_unit_test
{
    
    static class Program
    {
        
        static void Main(string[] args)
        {
            SortedList<string, DateTime> friendBirthday = new SortedList<string, DateTime>();
            friendBirthday.Add("dave", new DateTime(2022, 7, 14));
            foreach(KeyValuePair<string, DateTime> events in friendBirthday)
            {
                Console.WriteLine($"{events.Value.Month}/{events.Value.Day}/{events.Value.Year}");
            }
            Console.WriteLine("end");
        }
    }

}
