using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author:Raine Taber
//document for Unit test #2, questions 4-7

namespace Unit_Test_4_7
{
    //question 4: convert schUML to C#
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;
        public string PhoneNumber;
        public abstract void Connect();
        public abstract void Disconnect();
    }

    public interface IPhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, IPhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {
            
        }
    }

    public class PushButtonPhone : Phone, IPhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;
        public void OpenDoor()
        {

        }
        public void CloseDoor()
        {

        }
    }

    public class Tardis:RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho{ get { return whichDrWho; } }
        public string FemaleSideKick { get { return femaleSideKick; } }
        public void TimeTravel()
        {

        }

        //question 5: overload boolean operators
        //comparison operators are comparing tardis objects based on their whichDrWho value, in which case
        //they work normally, except for when the 10th doctor is involved, in which case the 10th doctor
        //is GREATER than every other doctor. this creates some fascinating logic
        public static bool operator == (Tardis tar1, Tardis tar2)
        {
            return tar1.whichDrWho.Equals(tar2.whichDrWho);
        }
        public static bool operator !=(Tardis tar1, Tardis tar2)
        {
            return tar1.whichDrWho.Equals(tar2.whichDrWho);
        }
        public static bool operator <(Tardis tar1, Tardis tar2)
        {
            if (tar1.whichDrWho.Equals(10) && tar2.whichDrWho.CompareTo(tar1.whichDrWho)==0)
            {
                return false;
            }
            else if(tar2.whichDrWho.Equals(10))
            {
                return true;
            }
            else if(tar1.whichDrWho.CompareTo(tar2.whichDrWho)!=-1 || tar1.whichDrWho.Equals(10))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator >(Tardis tar1, Tardis tar2)
        {
            if(tar1.whichDrWho.Equals(10)&&tar2.whichDrWho.CompareTo(tar1.whichDrWho)==0)
            {
                return false;
            }
            else if(tar1.whichDrWho.Equals(10))
            {
                return true;
            }
            else if(tar1.whichDrWho.CompareTo(tar2.whichDrWho)!=1||tar2.whichDrWho.Equals(10))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator <=(Tardis tar1, Tardis tar2)
        {
            if(tar2.whichDrWho.Equals(10))
            {
                return true;
            }
            else if(tar1.whichDrWho.CompareTo(tar2.whichDrWho)==1 || tar1.whichDrWho.Equals(10))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool operator >=(Tardis tar1, Tardis tar2)
        {
            if (tar1.whichDrWho.Equals(10))
            {
                return true;
            }
            else if (tar1.whichDrWho.CompareTo(tar2.whichDrWho) == -1 || tar2.whichDrWho.Equals(10))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            Tardis dis = new Tardis();
            PhoneBooth booth = new PhoneBooth();
            UsePhone(dis);
            UsePhone(booth);
        //UsePhone("yussss");
        }

        //question 6: UsePhone
        public static void UsePhone(object obj)
        {
            //establish ref variable
            IPhoneInterface iphone = null;
            try
            {
                //try to cast obj as an IPhoneInterface object, it'll tell you if the obj is
                //inheriting IPhoneInterface
                //proceed to set ref variable to obj casted properly, and call IPhoneInterface methods.
                iphone = (IPhoneInterface)obj;
                iphone.MakeCall();
                iphone.HangUp();
            }
            catch
            {
                Console.WriteLine("not an object inheriting IPhoneInterface");
            }

            //question 7: add functionality within this method for phoneboothes and tardis' in particular.

            //check if obj is a PhoneBooth object.
            //proceed to cast obj as a PhoneBooth object.
            //call phonebooth object using the myBooth ref variable.
            if (obj.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth myBooth = null;
                myBooth = (PhoneBooth)obj;
                myBooth.OpenDoor();
            }
            else if(obj.GetType()==typeof(Tardis))
            {
                Tardis SciFi = null;
                SciFi = (Tardis)obj;
                SciFi.TimeTravel();
            }
            else
            {
                Console.WriteLine("do you even have a phone?");
            }
        }
    }
}
