using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("Proverbs",3,5,6);
        var scripture = new Scriptures(reference,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            break;

            scripture.HideRandomWord();

    


        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All the words have been hidden");

    }
}