using System;
using System.IO;
using System.Runtime.CompilerServices;
class ReadAndWrite
{

    public static void _WriteFiles(string prompt, string answer, string dateText)
    {


        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "myFile.txt");
        Console.WriteLine($"The file will be saved at: {fileName}");

        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {



            outputFile.WriteLine($"{dateText},{prompt},{answer}");

        }
        Console.WriteLine("The file txt was saved");

    }

    public static string _ReadFiles()
    {
        string file = "";

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");s

            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];

            file = ($"{date} - {prompt} - {answer}");
        }

        Console.WriteLine("Loading the file.....");

        return file;
    }


}