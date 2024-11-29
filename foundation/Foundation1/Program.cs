using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");


        Video vid1 = new Video("The profet", "Joseph Smith", 23);
        string showInformatioVideo1 = vid1.GetInformationOfVideo();
        Console.WriteLine(showInformatioVideo1);

        
        Video vid2 = new Video("Gladiador", "juan", 30);
        string showInformatioVideo2 = vid2.GetInformationOfVideo();
        Console.WriteLine(showInformatioVideo2);

    }
}