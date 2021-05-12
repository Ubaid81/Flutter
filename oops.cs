using System;

namespace OOPS
{

    interface IMobile
    {
        void Dial();
    }

    public class Mobile : IMobile
    {
        public string IEMICode { get; set; }
        public string SIMCard { get; set; }
        public string Processor { get; set; }


        public void Dial()
        {
            Console.WriteLine("Dial a number");
        }
        public void Receive()
        {
            Console.WriteLine("Receive a call");
        }
        public virtual void SendMessage()
        {
            Console.WriteLine("Message Sent");
        }
    }


    public class Apple : Mobile
    {
        public void GetWIFIConnection()
        {
            Console.WriteLine("WIFI connected");
        }

        //This is one mwthod which shows camera functionality  
        public void CameraClick()
        {
            Console.WriteLine("Camera clicked");
        }

        //This is one overloaded method which shows camera functionality as well but with its camera's different mode(panaroma)  
        public void CameraClick(string CameraMode)
        {
            Console.WriteLine("Camera clicked in " + CameraMode + " Mode");
        }

        //New implementation for this method which was available in Mobile Class  
        //This is runtime polymorphism  
        public override void SendMessage()
        {
            Console.WriteLine("Message Sent where it's need to be sent.");
        }
    }


    public class Samsung : Mobile
    {
        public void GetBlueToothConnection()
        {
            Console.WriteLine("Bluetooth connected");
        }

        //New implementation for this method which was available in Mobile Class  
        //This is runtime polymorphism  
        public override void SendMessage()
        {
            Console.WriteLine("Message Sent to a group");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mobile obj1 = new Mobile();     //create a mobile object
                Apple obj2 = new Apple();      //create an apple object
                Samsung obj3 = new Samsung();    //create a samsung object

                Console.WriteLine("Enter Sim Card name : ");
                obj1.SIMCard = Console.ReadLine();
                Console.WriteLine("\nSIM CARD Name : " + obj1.SIMCard + "\n\n");


                Console.WriteLine("Enter :\n1 for Apple Mobile configuration \n2 for Samsung Mobile Configuration\n");
                int Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice == 1)
                {
                    Console.WriteLine("\nApple Mobile configuration\n");
                    obj2.GetWIFIConnection();
                    obj2.CameraClick();
                    obj2.CameraClick("plain");
                    obj2.SendMessage();
                }
                else if(Choice == 2)
                {
                    Console.WriteLine("\nSamsung Mobile configuration\n");
                    obj3.GetBlueToothConnection();
                    obj3.SendMessage();
                }
                else
                {
                    Console.WriteLine("Enter valid choice");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}