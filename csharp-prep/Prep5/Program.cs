using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        
        //welcome message        
        DisplayMessage();

        //introduce the name and number 
        string userName = InputName();
        int userNumber = InputNumber();


        //opertation 1 squareNumber 

        int squareNumber = SquareNumber(userNumber);


        //Show the information 

        Console.WriteLine($"Brother {userName}, the square of your number is: {squareNumber}");



    }

    static void DisplayMessage ()
    {
        Console.WriteLine("Hello welcome to my program");
    }



    static string InputName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int InputNumber()
    {

        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;

    }

    static int SquareNumber(int userNumber)
    {
        int favoriteNumber = userNumber;
        int square = userNumber * userNumber;
        return square;
    }



}