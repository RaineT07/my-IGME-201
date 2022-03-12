using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Raine Taber
//Unit test 2 question 10, converting question 8's schUML to C# and then demonstrating its polymorphism

namespace Unit_test_2_Q10
{
    
    public interface IFencer
    {
        void Advance();
        void Retreat();
        void Lunge();
    }
    public abstract class Fencing
    {
        public string name;
        public int speed;
        public int height;
        public double strategy;
        public abstract void Parry();
        public abstract void Riposte();

    }
    public interface IRules
    {
        bool RightOfWay { get; }
        void Score();
    }
    public class Ref : IRules
    {
        public string name;
        private bool rightOfWay;
        public bool RightOfWay { get { return rightOfWay; } }

        public virtual void Score()
        {
            Console.WriteLine($"{this.name}: Score is 5-6!");
        }
        
    }
    public class ScoreBoard : Ref
    {
        public string name;
        private bool rightOfWay;

        public bool RightOfWay { get { return rightOfWay; } }
        public override void Score()
        {
            Console.WriteLine("7-6!");
        }
        public void Finale(object fencer1, object fencer2)
        {
            
        }
        public void Win(object winner)
        {
            
        }
        public void Lose(object loser)
        {
            
        }
    }

    public class Foil : Fencing, IFencer
    {
        public string name;
        public int speed;
        public int height;
        public double strategy;
        public override void Parry()
        {
            Console.WriteLine($"{this.name}: Parries with a flourish!");
        }
        public override void Riposte()
        {
            Console.WriteLine($"{this.name}: Ripostes with a Lunge.");
        }
        public void Advance()
        {

        }
        public void Retreat()
        {

        }
        public void Lunge()
        {

        }
        public Foil()
        {
            name = "Jake";
            height = 100;
        }
        public Foil(string sName, int iHeight)
        {
            name = sName;
            height = iHeight;
        }
    }
    public class Eppe : Fencing, IFencer
    {
        public string name;
        public int speed;
        public int height;
        public double strategy;
        public override void Parry()
        {
            Console.WriteLine($"{this.name}: Parries with a retreat!");
        }
        public override void Riposte()
        {
            Console.WriteLine($"{this.name}: Ripostes with a spin-move.");
        }
        public void flail()
        {

        }
        public void Advance()
        {

        }
        public void Retreat()
        {

        }
        public void Lunge()
        {

        }
        public Eppe()
        {
            name = "Jane";
            height = 100;
        }
        public Eppe(string sName, int iHeight)
        {
            name = sName;
            height = iHeight;
        }

    }
    public class Saber : Foil
    {
        public string name;
        public int speed;
        public int height;
        public double strategy;
        public int Guts;
        public override void Parry()
        {
            Console.WriteLine($"{this.name}: Parries with a swipe!");
        }
        public override void Riposte()
        {
            Console.WriteLine($"{this.name}: Ripostes with an overhead strike.");
        }
        public void Advance()
        {

        }
        public void Retreat()
        {

        }
        public void Lunge()
        {

        }
        public Saber()
        {
            name = "Tim";
            height = 100;
        }
        public Saber(string sName, int iHeight) : base(sName, iHeight)
        {
            name = sName;
            height = iHeight;
        }

    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            Foil Ezra = new Foil("Ezra", rand.Next(120, 201));
            Saber Raine = new Saber("Raine", 154);
            Eppe Tim = new Eppe("Tim", rand.Next(120, 201));
            IncomingAttack(Raine);
            IncomingAttack(Ezra);
            IncomingAttack(Tim);
            
        }

        //IncomingAttack checks to see if given object is a Fencing object and then calls its Parry() function, demonstrating how different
        //classes with the same inherited class can have methods that are different with the same method signature
        static void IncomingAttack(object fen1)
        {
            Fencing fencer1 = null;
            try
            {
                fencer1 = (Fencing)fen1;
                fencer1.Parry();
            }
            catch
            {
                Console.WriteLine("One of these is not a fencer");
            }
        }
    }
}
