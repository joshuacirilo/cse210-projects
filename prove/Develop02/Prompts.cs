class Prompts
{

    public static string GeneratorPrompts()
    {

        List<string> questions = new List<string>
        {"What was a bad part of my day?","What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?","If I had one thing I could do over today, What would it be?"};

        Random random = new Random();

        int index = random.Next(questions.Count); 
        string prompts = (questions[index]);
        return prompts;
    }




}