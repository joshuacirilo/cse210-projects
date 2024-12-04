using System;
using Microsoft.VisualBasic;

class Scriptures
{

    private string _reference;
    private List<Word> Words;
    private string scriptureUse; 
    private string referenceUse;

    public Scriptures(string getReference, string text)
    {
        _reference = getReference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
        scriptureUse = text;
        referenceUse = getReference;

    }

    public void HideRandomWord()
    {

        Random random = new Random();

        var visibleWords = Words.Where(Word => !Word._isHidden).ToList();
        if (visibleWords.Any())
        {
            var randomWord = visibleWords[random.Next(visibleWords.Count)];
            randomWord.Hide();
        }


    }


    public string GetDisplayText()
    {

        return string.Join(" ", Words.Select(Word => Word.GetDisplayText())) + " - " + _reference;
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(Word => Word._isHidden);
    }



    public string FullText ()
    {
        string fullScripture = $"{scriptureUse} - {referenceUse}";
        return fullScripture;
    }

}