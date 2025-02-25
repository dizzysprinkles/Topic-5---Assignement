using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Topic_5___Assignement
{
    internal class Program
    {
        public static void Hurricane(int category)
        {
            switch (category)
            {
                case 1:
                    Console.WriteLine("A Category 1 hurricane has a speed of 74-95 mph, or 64-82 kt, or 119-153 km/h.");
                    break;
                case 2:
                    Console.WriteLine("A Category 2 hurricane has a speed of 96-110 mph, or 83-95 kt, or 154-177 km/h");
                    break;
                case 3:
                    Console.WriteLine("A Category 3 hurricane has a speed of 111-130 mph, or 96-113 kt, or 178-209 km/h");
                    break;
                case 4:
                    Console.WriteLine("A Category 4 hurricane has a speed of 131-155 mph, ot 114-135 kt, or 210-249 km/h");
                    break;
                case 5:
                    Console.WriteLine("A Category 5 hurricane has a speed that is GREATER than 155 mph, or 135 kt, or 249 km/h");
                    break;
            }

        }

        public static void Garage(int minutes)
        {
            Console.WriteLine();



            if (minutes % 60 > 0)
            {
                int hours = (minutes / 60) + 1;
                int price = 4 + (2 * (hours));
                if (price >= 20)
                {
                    price = 20;
                    Console.WriteLine("You parked for " + hours + " hours.");
                    Console.WriteLine("The total cost you are being charged for is: " + price.ToString("C"));

                }
                else
                {
                    Console.WriteLine("You parked for: " + hours + " hours.");
                    Console.WriteLine("The total cost you are being charged for is: " + price.ToString("C"));
                }

               
            }
            else
            {
                int hours = minutes / 60;
                int price = 4 + (2 * (hours));
                if (price >= 20)
                {
                    price = 20;
                    Console.WriteLine("You parked for " + hours + " hours.");
                    Console.WriteLine("The total cost you are being charged for is: " + price.ToString("C"));

                }
                else
                {
                    Console.WriteLine("You parked for: " + hours + " hours.");
                    Console.WriteLine("The total cost you are being charged for is: " + price.ToString("C"));
                }
               

            }
        }




        static void Main(string[] args)
        {
            // For full marks, add menu to select which part to run..
            string menuChoice = "";
            int degrees, category, minutes, price;

            while (menuChoice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Topic 5's menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Compass Bearing");
                Console.WriteLine("2 - Parking Garage");
                Console.WriteLine("3 - Hurricane");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                menuChoice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();


                //compass bearing - input degrees and state which direction (N,E,W,S)
                // 315-45 = N; 45-135 = E; 135-225 = S; 225-315 = W;
                // 315 = NW; 360/0 = N; 45=NE; 90 = E; 135 = SE; 180 = S; 225 = SW; 270 = W
                if (menuChoice == "1")
                {
                    Console.WriteLine("You chose option 1 - Compass Bearing");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Console.WriteLine("If you give me an angle, I can tell you what direction it would be pointing on a compass!");
                    Console.WriteLine("What angle would you like me to convert? ");
                }
                //Parking garage - $4 first hour, $2 every hour after, max of $20/day, input minutes
                else if (menuChoice == "2")
                {
                    Console.WriteLine("You chose option 2 - Parking Garage");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Console.WriteLine("Welcome to Sam's Parking Garage! Here's our rate: \n$4.00 for the first hour\n$2.00 per additional hour\nMaximum charge of $20.00 a day ");
                    Console.WriteLine();
                    Console.WriteLine("How many minutes did you park for? We round up to the closest hour!");
                    while (!Int32.TryParse(Console.ReadLine(), out minutes))
                    {
                        Console.WriteLine("Invalid number. Try again.");
                    }

                    Garage(minutes);
                    Console.WriteLine();
                    Console.WriteLine("Hit ENTER to return to main menu!");
                    Console.ReadLine();

                }
                //Hurricane - input what category, output speed in knots, km/h, mph
                else if (menuChoice == "3")
                {
                    Console.WriteLine("You chose option 3 - Hurricane");
                    Console.WriteLine("Hit ENTER to continue");
                    Console.ReadLine();
                    Console.WriteLine("Hey there! Tell me what category hurricane (1 to 5) you are interested and I will tell you what its speed is!");
                    while (!Int32.TryParse(Console.ReadLine(), out category) || category < 1 || category > 5)
                    {
                        Console.WriteLine("Invalid number. Try again.");
                    }
                    Hurricane(category);
                    Console.WriteLine("Hit ENTER to return to main menu!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to return to main menu.");
                    Console.ReadLine();
                }
            }


        }

       
    }
}
