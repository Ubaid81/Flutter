using System;

namespace EventConsoleApplication
{
    class EventData
    {
        private string name;
        public string Name { get; set; }

        private string date;
        public string Date { get; set; }

        private string timeslot;
        public string TimeSlot { get; set; }

        private int nguest;
        public int Nguest { get; set; }

        private string venue;
        public string Venue{ get; set; }

        private string decoration;
        public string Decoration { get; set; }

    }


    class Data : EventData
    {
        Data obj = new Data();
        public void Guest()
        {
            Console.WriteLine("Enter the total number of Guest");
            obj.Nguest = Convert.ToInt32(Console.ReadLine());
        }

        public void TIMESLOT()
        {
        A:
            Console.WriteLine("Choose the TimeSlot for the Event.\nEnter \n1 for Morning : 9am to 11am \n2 for Afternoon : 12pm to 3pm \n3 for Evening : 5pm to 8pm \n4 for Night : 9pm to 12am\n");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time < 0 || time > 4)
            {
                Console.WriteLine("Please enter the correct value as per given above");
                goto A;
            }
            if (time == 1)
            {
               obj.TimeSlot = " Morning : 9am to 11am ";
            }
            else if (time == 2)
            {
               obj.TimeSlot = " Afternoon : 12pm to 3pm ";
            }
            else if (time == 3)
            {
               obj.TimeSlot = " Evening : 5pm to 8pm ";
            } 
            else
            {
               obj.TimeSlot = " Night : 9pm to 12am ";
            }
        }

        public void DATE()
        {
            Console.WriteLine("Please Enter the Date of the event :");
            obj.Date = Console.ReadLine();
        }

    }

    class Birthday : EventData
    {
        Birthday obj1 = new Birthday();

        public void VENUE()
        {
        B:
            Console.WriteLine("Select the Venue by entering : \n1 for ROYAL OCCASION BANQUE  \n2 for Pascals The British Pub \n3 for Mandarin Trail\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            switch (venueType)
            {
                case 1:
                    Console.WriteLine("You have selected 'ROYAL OCCASION BANQUE' venue for your Birthday Celebration");
                    obj1.Venue = "ROYAL OCCASION BANQUE";
                    break;
                case 2:
                    Console.WriteLine("You have selected 'Pascals The British Pub' venue for your Birthday Celebration");
                    obj1.Venue = "Pascals The British Pub";
                    break;
                case 3:
                    Console.WriteLine("You have selected 'Mandarin Trail' venue for your Birthday Celebration");
                    obj1.Venue = "Mandarin Trail";
                    break;
                default:
                    Console.WriteLine("Please Enter as directed option for selecting decoration package.hence, Try Again!");
                    goto B;
            }
        }

        public void DECORATION()
        {
        C:
            Console.WriteLine("Select the Decoration Package by entering \n1 for 'Silver package' whose cost is Rs. 3000\n2 for 'Gold package' whose cost is Rs. 5000\n3 for 'Platinum package' whose cost is Rs. 10,000/n");
            int decor = Convert.ToInt32(Console.ReadLine());
            switch (decor)
            {
                case 1:
                    Console.WriteLine("You have selected the 'Silver Package' for your Birthday Celebration");
                    obj1.Decoration = "Silver Package";
                    break;
                case 2:
                    Console.WriteLine("You have selected 'Gold Package' for your Birthday Celebration");
                    obj1.Decoration = "Gold Package";
                    break;
                case 3:
                    Console.WriteLine("You have selected 'Platinum Package' for your Birthday Celebration");
                    obj1.Decoration = "Platinum Package";
                    break;
                default:
                    Console.WriteLine("Please Enter as directed option for selecting decoration package. Hence, Try Again!");
                    goto C;
            }

        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("");
            Console.WriteLine("welecome to xyz event organniser");

        label:
            Console.WriteLine("\n");
            Console.WriteLine("Choose from the following events that we manage: "); //Getting the selection of the event
            Console.WriteLine("Enter 1 for a Birthday Celebration Event.");
            Console.WriteLine("Enter 2 for a Wedding Event.");
            Console.WriteLine("Enter 3 for a Kitty Party Event.");
            Console.WriteLine("Enter 4 for a Bachelor Party Event.");
            Console.WriteLine("Enter your event selection: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            int select = selection;
            if (selection < 0 || selection > 4)
            {
                Console.WriteLine("Please enter the correct value as per given above");
                goto label;
            }
            else
            {
                Console.WriteLine("Great! , Now mention or select other details regarding the event");
            }

            if (selection == 1)
            {
                Data obj2 = new Data();
                obj2.Guest();
                obj2.DATE();
                obj2.TIMESLOT();
                Birthday obj3 = new Birthday();
                obj3.VENUE();
                obj3.DECORATION();
                EventData obj4 = new EventData();

                Console.WriteLine("print" + obj4.Name + obj4.Nguest + obj4.TimeSlot + obj4.Venue + obj4.Decoration);
            }

        }
    }
}