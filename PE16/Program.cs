using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE16
{
    public interface IMood
    {
        string Mood { get; }
    }
    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public abstract void Steam();
        public virtual void AddSugar(byte amount)
        {
            this.sugar += amount;
        }
        public HotDrink()
        {

        }
        public HotDrink(string brand)
        {

        }
    }

    public class Waiter : IMood
    {
        public string name;
        public string Mood { get; }
        public void ServeCustomer(HotDrink cup)
        {
            Console.WriteLine("customer served!");
        }
    }

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;
        public string Mood { get; }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;
        public override void Steam()
        {
            Console.WriteLine("coffee steaming");
        }
        public void TakeOrder()
        {
            Console.WriteLine("black coffee with lots of sugar please");
        }

        public CupOfCoffee(string brand):base(brand)
        {

        }
    }

    public class CupOfTea:HotDrink , ITakeOrder
    {
        public string leafType;
        public override void Steam()
        {
            Console.WriteLine("tea steaming");
        }

        public void TakeOrder()
        {
            Console.WriteLine("green tea with no sugar please.");
        }
        public CupOfTea(bool customerIsWealthy)
        {

        }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;
        public string Source
        {
            set
            {
                this.source = value;
            }
        }
        public override void Steam()
        {
            Console.WriteLine("cocoa steaming.");
        }
        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }
        public void TakeOrder()
        {

        }
        CupOfCocoa() : this(false)
        {

        }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {

        }
            



    }
}
