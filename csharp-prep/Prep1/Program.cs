using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is you last name? ");
        string LastName = Console.ReadLine();


        Console.WriteLine($"Your name is {name}, {name} {LastName}.");
       
    }
}