using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        //object1
        Job job1 = new Job();
        job1._jobTitle = "software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2022;


        //object2
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Joshua Cirilo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}