using System;

namespace EventConsoleApplication
{
    interface IprintEndMessage //Print specific registration success message for every type of event.
    {
        public void Message();
    }

    class EventData         //parent class in which data member are private 
                            //and their are public get and set method call to achieve Encapsulation
    {
        private string name;                            //Field
        public string Name { get; set; }                //property

        private string date;
        public string Date { get; set; }

        private string timeslot;
        public string TimeSlot { get; set; }

        private int nguest;
        public int Nguest { get; set; }

        private string venue;
        public string Venue { get; set; }

        private string decoration;
        public string Decoration { get; set; }

        private string package;
        public string Package { get; set; }

        private double expenditure;
        public double Expenditure { get; set; }


    }

    // Drived class || Child class  which inherit data member from parent class to achive Inheritence property

    class Data : EventData
    {
        public int Guest()
        {
            try
            {
                Console.WriteLine("\n\nEnter the total number of Guest");
                int guest1 = Convert.ToInt32(Console.ReadLine());
                return guest1;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR! , Enter Correct format input");
                Console.WriteLine(e.Message);
                return 0;
                Environment.Exit(2);
            }
        }

        public string TIMESLOT()
        {
            try
            {
            A:
                Console.WriteLine("\n\nChoose the TimeSlot for the Event by enter. \n1 for Morning : 9am to 11am \n2 for Afternoon : 12pm to 3pm \n3 for Evening : 5pm to 8pm \n4 for Night : 9pm to 12am\n");
                int time = Convert.ToInt32(Console.ReadLine());
                string time1;
                if (time < 0 || time > 4)
                {
                    Console.WriteLine("\nPlease enter the correct value as per given above");
                    goto A;
                }
                if (time == 1)
                {
                    time1 = "Morning : 9am to 11am";
                    return time1;
                }
                else if (time == 2)
                {
                    time1 = "Afternoon : 12pm to 3pm";
                    return time1;
                }
                else if (time == 3)
                {
                    time1 = "Evening : 5pm to 8pm ";
                    return time1;
                }
                else
                {
                    time1 = "Night : 9pm to 12am ";
                    return time1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR! , Enter Correct format input");
                Console.WriteLine(e.Message);
                return "";

            }
        }

        public string DATE()
        {
            Console.WriteLine("\n\nPlease Enter the Date of the event in DD MMM YYYY format:");
            string date1 = Console.ReadLine();
            return date1;
        }

    }


    //all the four method in each class birthday ||  wedding || kitty || babyshower
    //show example of polymorphism as method name is same but they have different functionality


    class Birthday : IprintEndMessage
    {
        public string VENUE()
        {
        B:
            Console.WriteLine("\n\nSelect the Venue by entering : \n1 for ROYAL OCCASION BANQUE  \n2 for PASCAlS THE BRITISH PUB \n3 for MANDARIN TRAIL\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            string venue1;
            switch (venueType)
            {
                case 1:
                    Console.WriteLine("\nYou have selected 'ROYAL OCCASION BANQUE' venue for your Birthday Celebration");
                    venue1 = "ROYAL OCCASION BANQUE";
                    return venue1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'PASCAlS THE BRITISH PUB' venue for your Birthday Celebration");
                    venue1 = "PASCAlS THE BRITISH PUB";
                    return venue1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'MANDARIN TRAIL' venue for your Birthday Celebration");
                    venue1 = "MANDARIN TRAIL";
                    return venue1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting Venue. Hence, Try Again!");
                    goto B;
            }
        }

        public string DECORATION()
        {
        C:
            Console.WriteLine("\n\nSelect the Decoration Package by entering \n1 for 'Silver package' whose cost is Rs. 3000\n2 for 'Gold package' whose cost is Rs. 5000\n3 for 'Platinum package' whose cost is Rs. 10,000\n");
            int decor = Convert.ToInt32(Console.ReadLine());
            string decor1;
            switch (decor)
            {
                case 1:
                    Console.WriteLine("\nYou have selected the 'Silver Package' for your Birthday Celebration");
                    decor1 = "Silver Package";
                    return decor1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'Gold Package' for your Birthday Celebration");
                    decor1 = "Gold Package";
                    return decor1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'Platinum Package' for your Birthday Celebration");
                    decor1 = "Platinum Package";
                    return decor1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting decoration package. \nHence, Try Again!");
                    goto C;
            }

        }

        public string PACKAGE()     //   catering package method
        {
        D:
            Console.WriteLine("\n");
            Console.WriteLine("Choose one of the following Catering packages: ");
            Console.WriteLine("Press 1 for Premium (1000 per person)");
            Console.WriteLine("Press 2 for Regular (600 per person)");
            Console.WriteLine("Press 3 for Budget (300 per person)");
            Console.WriteLine("Enter your choice: ");
            int select = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string pack1;
            if (select == 1)
            {
                pack1 = "Premium Package";
                return pack1;
            }

            else if (select == 2)
            {
                pack1 = "Regular Package";
                return pack1;
            }

            else if (select == 3)
            {
                pack1 = "Regular Package";
                return pack1;
            }
            else
            {
                System.Console.WriteLine("\nEntered the Wrong Choice . Try Again!");
                goto D;
            }
        }

        public double EXPENDITURE(string package, int guest)
        {
            double exp;
            if (package == "Premium Package") // Premium Package
            {
                exp = 1000 * guest + 6000;
                return exp;
            }

            else if (package == "Regular Package") // Regular Package
            {
                exp = 600 * guest + 4000;
                return exp;
            }

            else  // Budget Package
            {
                exp = 300 * guest + 2000;
                return exp;
            }
        }

        public void Message()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Thankyou for visiting us.");
        }
    }

    class Wedding : IprintEndMessage
    {
        public string VENUE()
        {
        E:
            Console.WriteLine("\n\nSelect the Venue by entering : \n1 for VILA BALBIANO  \n2 BLACKBERRY FARM \n3 for FAENA HOTEL\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            string venue1;
            switch (venueType)
            {
                case 1:
                    Console.WriteLine("\nYou have selected 'VILA BALBIANO' venue for your Wedding");
                    venue1 = "VILA BALBIANO";
                    return venue1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'BLACKBERRY FARM' venue for your Wedding");
                    venue1 = "BLACKBERRY FARM";
                    return venue1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'FAENA HOTEL' venue for your Wedding");
                    venue1 = "FAENA HOTEL";
                    return venue1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting Venue. Hence, Try Again!");
                    goto E;
            }
        }

        public string DECORATION()
        {
        F:
            Console.WriteLine("Select the Decoration Package by entering \n1 for 'Silver package' whose cost is Rs. 30000\n2 for 'Gold package' whose cost is Rs. 18000\n3 for 'Platinum package' whose cost is Rs. 10,000\n");
            int decor = Convert.ToInt32(Console.ReadLine());
            string decor1;
            switch (decor)
            {
                case 1:
                    Console.WriteLine("\nYou have selected the 'Silver Package' for your Wedding");
                    decor1 = "Silver Package";
                    return decor1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'Gold Package' for your Wedding");
                    decor1 = "Gold Package";
                    return decor1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'Platinum Package' for your Wedding");
                    decor1 = "Platinum Package";
                    return decor1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting decoration package.\nHence, Try Again!");
                    goto F;
            }

        }

        public string PACKAGE()
        {
        G:
            Console.WriteLine("\n");
            Console.WriteLine("Choose one of the following Catering packages: ");
            Console.WriteLine("Press 1 for Premium (3000 per person)");
            Console.WriteLine("Press 2 for Regular (1500 per person)");
            Console.WriteLine("Press 3 for Budget (900 per person)");
            Console.WriteLine("Enter your choice: ");
            int select = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string pack1;
            if (select == 1)
            {
                pack1 = "Premium Package";
                return pack1;
            }

            else if (select == 2)
            {
                pack1 = "Regular Package";
                return pack1;
            }

            else if (select == 3)
            {
                pack1 = "Regular Package";
                return pack1;
            }
            else
            {
                System.Console.WriteLine("\nEntered the Wrong Choice . Try Again!");
                goto G;
            }
        }

        public double EXPENDITURE(string package, int guest)
        {
            double exp;
            if (package == "Premium Package") // Premium Package
            {
                exp = 3000 * guest + 5000;
                return exp;
            }

            else if (package == "Regular Package") // Regular Package
            {
                exp = 1500 * guest + 4000;
                return exp;
            }

            else  // Budget Package
            {
                exp = 900 * guest + 3000;
                return exp;
            }
        }

        public void Message()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Thankyou for visiting us.");
        }
    }

    class Kitty : IprintEndMessage
    {
        public string VENUE()
        {
        H:
            Console.WriteLine("\n\nSelect the Venue by entering : \n1 for PALOMINO \n2 for MANDIHILLS \n3 for VENUELOOK\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            string venue1;
            switch (venueType)
            {
                case 1:
                    Console.WriteLine("\nYou have selected 'PALOMINO' venue for your Kitty Party");
                    venue1 = "PALOMINO";
                    return venue1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'MANDIHILLS' venue for your Kitty Party");
                    venue1 = "MANDIHILLS";
                    return venue1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'VENUELOOK' venue for your Kitty Party");
                    venue1 = "VENUELOOK";
                    return venue1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting Venue. Hence, Try Again!");
                    goto H;
            }
        }

        public string DECORATION()
        {
        I:
            Console.WriteLine("\n\nSelect the Decoration Package by entering \n1 for 'Silver package' whose cost is Rs. 2000\n2 for 'Gold package' whose cost is Rs. 3500\n3 for 'Platinum package' whose cost is Rs. 5000\n");
            int decor = Convert.ToInt32(Console.ReadLine());
            string decor1;
            switch (decor)
            {
                case 1:
                    Console.WriteLine("\nYou have selected the 'Silver Package' for your Kitty Party");
                    decor1 = "Silver Package";
                    return decor1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'Gold Package' for your Kitty Party");
                    decor1 = "Gold Package";
                    return decor1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'Platinum Package' for your Kitty Party");
                    decor1 = "Platinum Package";
                    return decor1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting decoration package. Hence, Try Again!");
                    goto I;
            }

        }

        public string PACKAGE()
        {
        J:
            Console.WriteLine("\n");
            Console.WriteLine("Choose one of the following Catering packages: ");
            Console.WriteLine("Press 1 for Premium (800 per person)");
            Console.WriteLine("Press 2 for Regular (400 per person)");
            Console.WriteLine("Press 3 for Budget (200 per person)");
            Console.WriteLine("Enter your choice: ");
            int select = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string pack1;
            if (select == 1)
            {
                pack1 = "Premium Package";
                return pack1;
            }

            else if (select == 2)
            {
                pack1 = "Regular Package";
                return pack1;
            }

            else if (select == 3)
            {
                pack1 = "Regular Package";
                return pack1;
            }
            else
            {
                System.Console.WriteLine("\nEntered the Wrong Choice . Try Again!");
                goto J;
            }
        }

        public double EXPENDITURE(string package, int guest)
        {
            double exp;
            if (package == "Premium Package") // Premium Package
            {
                exp = 800 * guest + 5000;
                return exp;
            }

            else if (package == "Regular Package") // Regular Package
            {
                exp = 400 * guest + 4000;
                return exp;
            }

            else  // Budget Package
            {
                exp = 200 * guest + 3000;
                return exp;
            }
        }

        public void Message()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Thankyou for visiting us.");
        }
    }

    class BabyShower : IprintEndMessage
    {
        public string VENUE()
        {
        K:
            Console.WriteLine("\n\nSelect the Venue by entering : \n1 for IMPERIAL BANQUET  \n2 for FORK & SPOON \n3 for THE RITVAAN\n");
            int venueType = Convert.ToInt32(Console.ReadLine());
            string venue1;
            switch (venueType)
            {
                case 1:
                    Console.WriteLine("\nYou have selected 'IMPERIAL BANQUET' venue for Baby Shower");
                    venue1 = "IMPERIAL BANQUET";
                    return venue1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'FORK & SPOON' venue for Baby Shower");
                    venue1 = "FORK & SPOON";
                    return venue1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'THE RITVAAN' venue for Baby Shower");
                    venue1 = "THE RITVAAN";
                    return venue1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting Venue. Hence, Try Again!");
                    goto K;
            }
        }

        public string DECORATION()
        {
        L:
            Console.WriteLine("\n\nSelect the Decoration Package by entering \n1 for 'Silver package' whose cost is Rs. 2000\n2 for 'Gold package' whose cost is Rs. 4000\n3 for 'Platium package' whose cost is Rs. 7000\n");
            int decor = Convert.ToInt32(Console.ReadLine());
            string decor1;
            switch (decor)
            {
                case 1:
                    Console.WriteLine("\nYou have selected the 'Silver Package' for your Birthday Celebration");
                    decor1 = "Silver Package";
                    return decor1;
                    break;
                case 2:
                    Console.WriteLine("\nYou have selected 'Gold Package' for your Birthday Celebration");
                    decor1 = "Gold Package";
                    return decor1;
                    break;
                case 3:
                    Console.WriteLine("\nYou have selected 'Platinum Package' for your Birthday Celebration");
                    decor1 = "Platinum Package";
                    return decor1;
                    break;
                default:
                    Console.WriteLine("\nPlease Enter as directed option for selecting decoration package. Hence, Try Again!");
                    goto L;
            }

        }

        public string PACKAGE()
        {
        M:
            Console.WriteLine("\n");
            Console.WriteLine("Choose one of the following Catering packages: ");
            Console.WriteLine("Press 1 for Premium (800 per person)");
            Console.WriteLine("Press 2 for Regular (500 per person)");
            Console.WriteLine("Press 3 for Budget (200 per person)");
            Console.WriteLine("Enter your choice: ");
            int select = Convert.ToInt32(Console.ReadLine()); //Getting the pacakge selection as input.

            string pack1;
            if (select == 1)
            {
                pack1 = "Premium Package";
                return pack1;
            }

            else if (select == 2)
            {
                pack1 = "Regular Package";
                return pack1;
            }

            else if (select == 3)
            {
                pack1 = "Regular Package";
                return pack1;
            }
            else
            {
                System.Console.WriteLine("\nEntered the Wrong Choice . Try Again!");
                goto M;
            }
        }

        public double EXPENDITURE(string package, int guest)
        {
            double exp;
            if (package == "Premium Package") // Premium Package
            {
                exp = 800 * guest + 5000;
                return exp;
            }

            else if (package == "Regular Package") // Regular Package
            {
                exp = 500 * guest + 4000;
                return exp;
            }

            else  // Budget Package
            {
                exp = 200 * guest + 3000;
                return exp;
            }
        }

        public void Message()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Thankyou for visiting us.");
        }
    }

    //Driver class
    class Program
    {
        //A static method display is used to display the event details....
        static void Display(string name, string schedule, int guest, string package, string venue, string decoration, double expenditure)
        {
            // Displaying all the details regarding the event
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Here's the details of the event you are planning for:\n");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("Event Name                : " + name);
            Console.WriteLine("Event Schedule            : " + schedule);
            Console.WriteLine("Expected number of guest  : " + guest);
            Console.WriteLine("Your selected package     : " + package);
            Console.WriteLine("Your selected venue       : " + venue);
            Console.WriteLine("Your selected decoration  : " + decoration);
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("Total expected expenditure for your event is Rs. " + expenditure);
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("");
                Console.WriteLine("\n\n\n\t\t\twelecome to xyz event organisation");

            label:
                Console.WriteLine("\n");
                Console.WriteLine("Choose from the following events that we manage: "); //Getting the selection of the event
                Console.WriteLine("Enter 1 for a Birthday Celebration .");
                Console.WriteLine("Enter 2 for a Wedding .");
                Console.WriteLine("Enter 3 for a Kitty Party .");
                Console.WriteLine("Enter 4 for a Baby Shower.");
                Console.WriteLine("Enter your event selection: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                int select = selection;
                if (selection < 0 || selection > 4)
                {
                    Console.WriteLine("\nPlease enter the correct value as per given above");
                    goto label;
                }
                else
                {
                    Console.WriteLine("\nGreat! , Now mention or select other details regarding the event");
                }

                Data obj2 = new Data();
                Birthday obj3 = new Birthday();
                Wedding obj4 = new Wedding();
                Kitty obj5 = new Kitty();
                BabyShower obj6 = new BabyShower();


                obj2.Nguest = obj2.Guest();
                obj2.Date = obj2.DATE();
                obj2.TimeSlot = obj2.TIMESLOT();

                if (selection == 1)
                {
                    obj2.Name = "Birthday Celebration";
                    obj2.Venue = obj3.VENUE();
                    obj2.Decoration = obj3.DECORATION();
                    obj2.Package = obj3.PACKAGE();
                    obj2.Expenditure = obj3.EXPENDITURE(obj2.Package, obj2.Nguest);

                    // Display(obj2.Name, obj2.TimeSlot, obj2.Nguest, obj2.Package, obj2.Venue, obj2.Decoration, obj2.Expenditure);
                }

                else if (selection == 2)
                {
                    obj2.Name = "Wedding";
                    obj2.Venue = obj4.VENUE();
                    obj2.Decoration = obj4.DECORATION();
                    obj2.Package = obj4.PACKAGE();
                    obj2.Expenditure = obj4.EXPENDITURE(obj2.Package, obj2.Nguest);
                }

                else if (selection == 3)
                {
                    obj2.Name = "Kitty Party";
                    obj2.Venue = obj5.VENUE();
                    obj2.Decoration = obj5.DECORATION();
                    obj2.Package = obj5.PACKAGE();
                    obj2.Expenditure = obj5.EXPENDITURE(obj2.Package, obj2.Nguest);
                }

                else
                {
                    obj2.Name = "Wedding";
                    obj2.Venue = obj6.VENUE();
                    obj2.Decoration = obj6.DECORATION();
                    obj2.Package = obj6.PACKAGE();
                    obj2.Expenditure = obj6.EXPENDITURE(obj2.Package, obj2.Nguest);
                }

                Display(obj2.Name, obj2.TimeSlot, obj2.Nguest, obj2.Package, obj2.Venue, obj2.Decoration, obj2.Expenditure);
                obj3.Message();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR! , Enter Correct format input");
                Console.WriteLine(e.Message);

            }
        }
    }
}