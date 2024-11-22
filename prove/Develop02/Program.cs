using System;

class Program
{


    static void Main(string[] args)
    {
        int choice = 0;
        string answer = "";
        //prompts
        string prompt = Prompts.GeneratorPrompts();
        string display = "";

        //date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        do
        {
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine("Welcome to the journe program");
            Console.WriteLine("Please select one of the following choice: ");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(prompt);
                    answer = Console.ReadLine();
                    break;

                case 2:
                    display = ReadAndWrite._ReadFiles();
                    Console.WriteLine(display);
                    break;

                case 3:
                    Console.WriteLine("Option 3:");
                    Console.WriteLine("Loading the file.....");
                    break;

                case 4:
                    Console.WriteLine("Option 4:");
                    ReadAndWrite._WriteFiles(prompt, answer, dateText);
                    break;
                case 5:
                    Console.WriteLine("Thanks for using this programm :)");
                    break;

                default:
                    Console.WriteLine("The number chosen is not an option");
                    break;

            }






        }
        while (choice != 5);





    }
}