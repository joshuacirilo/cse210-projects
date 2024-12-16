using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)

    {
        int choice;
        do
        {
            Console.WriteLine("Hello Develop05 World!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    activity.Run();
                    break;

                case 2:
                    activity = new ReflectingActivity();
                    activity.Run();
                    break;

                case 3:
                    activity = new ListingActivity();
                    activity.Run();
                    break;

                case 4:
                    Console.WriteLine("Thank you for participating. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }


        } while (choice != 4);


    }
}