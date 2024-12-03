using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        //video
        Video vid1 = new Video("The profet", "Joseph Smith", 23);
        string showInformatioVideo1 = vid1.GetInformationOfVideo();

        //comments

        Comment com1 = new Comment("Peter", "The video is good");
        string showComment1 = com1.GetInformationOfComment();

        Comment com2 = new Comment("Juan", "The video is too short");
        string showComment2 = com2.GetInformationOfComment();

        Comment com3 = new Comment("Teny", "The people in the video are tall");
        string showComment3 = com3.GetInformationOfComment();

        Console.WriteLine(showInformatioVideo1);
        Console.WriteLine(showComment1);
        Console.WriteLine(showComment2);
        Console.WriteLine(showComment3);


        Console.WriteLine("----------------------");

        //video
        Video vid2 = new Video("Sherk", "juan", 30);
        string showInformatioVideo2 = vid2.GetInformationOfVideo();
        Console.WriteLine(showInformatioVideo2);

        //comments


        Comment comv21 = new Comment("steven", "Why sherk is green?");
        string showCommentVideo21 = comv21.GetInformationOfComment();

        Comment comv22 = new Comment("Andrrea", "I love this video");
        string showCommentVideo22 = comv22.GetInformationOfComment();

        Comment comv23 = new Comment("Nataly", "I don´t like sherk");
        string showCommentVideo23 = comv23.GetInformationOfComment();


        Console.WriteLine(showCommentVideo21);
        Console.WriteLine(showCommentVideo22);
        Console.WriteLine(showCommentVideo23);


        Console.WriteLine("----------------------");

        //video
        Video vid3 = new Video("Gladiator", "Jorge", 10);
        string showInformatioVideo3 = vid3.GetInformationOfVideo();

        //comment 
        Comment comv31 = new Comment("Teresa", "I like this movie");
        string showCommentVideo31 = comv31.GetInformationOfComment();

        Comment comv32 = new Comment("Freddy", "I like the fighter movies");
        string showCommentVideo32 = comv32.GetInformationOfComment();

        Comment comv33 = new Comment("Carlos", "Maximus is the goat");
        string showCommentVideo33 = comv33.GetInformationOfComment();

        Console.WriteLine(showInformatioVideo3);
        Console.WriteLine(showCommentVideo31);
        Console.WriteLine(showCommentVideo32);
        Console.WriteLine(showCommentVideo33);





    }
}