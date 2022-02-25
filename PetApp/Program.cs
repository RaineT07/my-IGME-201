using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Raine Taber
    //pet class that has different pets that do varying things

    //abstract class pet holds 2 fields, name and age, which are a private string and public int respectively.
    //there's a basic getter and setter for name since it's private, as well as three methods, eat, play, and goToVet
    //there are two constructors, one that takes no params, and one that takes 2 params, a string and int for name and age.
    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public abstract void Eat();
        public abstract void Play();
        public abstract void GoToVet();
        public Pet()
        {
            name = "fluffy";
            age = 5;
        }
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    //interface ICat has 4 methods, eat, play, scratch, and purr, which are established for use by the Cat class
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
    }
    //class for a Cat, holds methods from ICat and Pet. all methods display the pet's name and the action for each method

    public class Cat : Pet, ICat
    {
        //from ICat and Pet
        public override void Eat()
        {
            Console.WriteLine($"{this.Name}: Wet food is my favorite.");
        }
        //from ICat and Pet
        public override void Play()
        {
            Console.WriteLine($"{this.Name}: I'll pounce on you!");
        }
        //from ICat
        public void Purr()
        {
            Console.WriteLine($"{this.Name}: Purrrrr..");
        }
        //from ICat
        public void Scratch()
        {
            Console.WriteLine($"{this.Name}: Hiss!");
        }
        //from Pet
        public override void GoToVet()
        {
            Console.WriteLine($"Hiss, I hate the vet.");
        }
        public Cat()
        {
            this.Name = "";
            this.age = 1;
        }
    }
    //interface IDog has 5 methods, eat, play, bark, needWalk, and GoToVet, which are implemented in the dog class.

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GoToVet();
    }
    //dog class inherits from pet class and IDog interface, and overwrites each of the pet methods with specific actions, as well as IDogs methods.
    //class also holds license
    public class Dog : Pet, IDog
    {
        public string license;
        public override void Eat()
        {
            Console.WriteLine($"{this.Name}: Yummy, I will eat anything!");
        }
        public override void Play()
        {
            Console.WriteLine($"{this.Name}: Throw the ball, run with me!");
        }
        public void Bark()
        {
            Console.WriteLine($"{this.Name}: Woof, woof!");
        }
        public void NeedWalk()
        {
            Console.WriteLine($"{this.Name}: Woof woof, time for a walk?");
        }
        public override void GoToVet()
        {
            Console.WriteLine($"{this.Name}: Whimper, whimper, no vet!");
        }
        //constructor takes 3 variables, 2 of which also work on the base constructor to apply name and age to proper variables. 
        public Dog(string szLicense, string szName, int nAge) : base(szName,nAge)
        {
            this.license = szLicense;
            this.Name = szName;
            this.age = nAge;
        }
    }

    //pets class creates a list of pets, and has petEl for its indexer, Count for its count of pets, an Add() method to add a pet to the list, a Remove() method to remove a pet from the list
    //it also has a RemoveAt() Method to remove a pet at the indexer petEl
    public class Pets
    {
        //petList stores a list of all pets
        List<Pet> petList = new List<Pet>();
        //getter and setter for nPetEl
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }
                return (returnVal);
            }

            set
            {
                if (nPetEl < petList.Count)
                {
                    petList[nPetEl] = value;
                }
                else
                {
                    petList.Add(value);
                }
            }
        }
        //getter and setter for a Count variable
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }
        //adds a pet to the list
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
        //removes a pet from the list
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        //removes a pet at a certain index of the list
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //ref variables
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            //random and pet list variables
            Pets pets = new Pets();
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                //check if you buy an animal, if not pick an animal from the list and do a random action
                if (rand.Next(1, 11) == 1)
                {
                    //buy dog or cat
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's Name=> ");
                        string tempName = Console.ReadLine();
                        bool bValid = false;
                        int tempAge = 0;
                        while (!bValid)
                        {
                            Console.Write("Age=> ");
                            string STempAge = Console.ReadLine();
                            bValid = int.TryParse(STempAge, out tempAge);
                        }
                        Console.Write("License => ");
                        string tempLicense = Console.ReadLine();
                        thisPet = new Dog(tempLicense, tempName, tempAge);
                        pets.Add(thisPet);
                    }
                    else
                    {
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's Name=> ");
                        string tempName = Console.ReadLine();
                        bool bValid = false;
                        int tempAge = 0;
                        while (!bValid)
                        {
                            Console.Write("Age=> ");
                            string STempAge = Console.ReadLine();
                            bValid = int.TryParse(STempAge, out tempAge);
                        }
                        thisPet = new Cat();
                        thisPet.Name = tempName;
                        thisPet.age = tempAge;
                        pets.Add(thisPet);

                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do

                    int randPet = rand.Next(0, pets.Count);
                    //if the pet at random index is null, continue to next iteration of the for-loop
                    if (pets[randPet]==null)
                    {
                        continue;
                    }
                    //check if the pet is a dog or cat, and choose a random cat or dog method accordingly
                        int randAct;
                    thisPet = pets[randPet];
                    if(thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (Cat)thisPet;
                        randAct = rand.Next(1, 5);
                        switch (randAct)
                        {
                            case 1:
                                iCat.Eat();
                                break;
                            case 2:
                                iCat.Play();
                                break;
                            case 3:
                                iCat.Purr();
                                break;
                            case 4:
                                iCat.Scratch();
                                break;
                            

                        }
                    }
                    else if(thisPet.GetType() == typeof(Dog))
                    {
                        iDog = (Dog)thisPet;
                        randAct = rand.Next(1, 7);
                        switch (randAct)
                        {
                            case 1:
                                iDog.Eat();
                                break;
                            case 2:
                                iDog.Play();
                                break;
                            case 3:
                                iDog.Bark();
                                break;
                            case 4:
                                iDog.NeedWalk();
                                break;
                            case 5:
                                iDog.GoToVet();
                                break;
                        }
                    }
                }

            }
        }
    }
}
