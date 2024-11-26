using System;
using Microsoft.VisualBasic;

class Scriptures
{

    private Reference _reference;
    private List<Word> Words;

    public Scriptures(Reference Reference, string text)
    {
        _reference = Reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
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

}