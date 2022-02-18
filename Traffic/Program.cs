using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    //Author: Raine taber
    //program calls new method addPassengers on two different objects
    class Program
    {
        static void Main(string[] args)
        {
            IPassengerCarrier mySuv = new SUV();
            AddPassengers(ref mySuv);
            Train myFreight = new FreightTrain();
            AddPassengers(ref myFreight); //yes I'm aware this causes an error, this is what happens when I try to pass an object that did not inherit IPassengerCarrier.

        }
        static public void AddPassengers(ref IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();

            if (vehicleObject.GetType()==typeof(Vehicle))
            {
                Console.WriteLine(vehicleObject.ToString());
            }
        }
    }
}
