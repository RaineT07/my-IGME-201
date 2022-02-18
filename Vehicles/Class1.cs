using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Raine taber
//dll that has a library of different vehicles.
namespace Vehicles
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {
            Console.WriteLine("I am a vehicle");
        }
    }

     public abstract class Car : Vehicle
    {

    }

     public abstract class Train : Vehicle
    {

    }

    public interface IPassengerCarrier
    {
        void LoadPassenger()
        {
            Console.WriteLine("I am a passenger Carrier");
        }

    }

    public interface IHeavyLoadCarrier
    {

    }

    public class Compact : Car, IPassengerCarrier
    {
        
        
    }

    public class SUV : Car, IPassengerCarrier
    {


    }

    public class Pickup : Car, IPassengerCarrier , IHeavyLoadCarrier
    {


    }

    public class PassengerTrain : Train , IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class _424DoubleBogey : Train , IHeavyLoadCarrier
    {

    }
}
