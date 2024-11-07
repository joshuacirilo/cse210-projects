using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string percentage =  Console.ReadLine();
        int percent = int.Parse(percentage);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";

        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >=70)
        {
            letter = "C";
        }
        else if(percent >=60)
        {
            letter = "D";
        }
        else if (percent <=60 && percent >= 0)
        {
            letter = "F";
        }
        else 
        {
            letter = "the percentage is not valid";
        }


        if(percent>=70)
        {
            Console.WriteLine("Pass the class");
        }
        else 
        {
            Console.WriteLine("try again, you can do it");
        }
        

        Console.Write($"Your grade is {letter}");

    }
}