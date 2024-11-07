using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 100);
        


        int GuessNumber = 0;

        do
        {
            Console.Write("What is your gess?  ");
            GuessNumber = int.Parse(Console.ReadLine());


            if (MagicNumber > GuessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (MagicNumber < GuessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (MagicNumber == GuessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (MagicNumber != GuessNumber);




    }

}