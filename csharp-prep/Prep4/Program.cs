using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


        //Create list

        List<int> numbers = [];
        int reapeater = 1;
        int sum = 0;
        double average = 0;

        do
        {

            //add numbers
            Console.Write("What number would you like to add to the list: ");
            string NumberInput = Console.ReadLine();
            int number = int.Parse(NumberInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.Write("Thanks for using this program");
                reapeater = 0;
            }
        } while (reapeater != 0);

        //operations 
        for (int i = 0; i < numbers.Count; i++)
        {
            //Sum 
            sum = sum + numbers[i];


        }

        //average 
        average = sum / numbers.Count;
        Console.WriteLine($"The sum in the list is: {sum}");
        Console.WriteLine($"The Average of the list is: {average}");


        //The max

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {

                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");


        Console.Write($"The max number is: {max}");

    }
}