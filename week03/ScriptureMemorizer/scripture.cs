using ScriptureMemorizer;
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', ';', ':', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> availableWords = _words.Where(w => !w.IsHidden()).ToList();
        
        if (availableWords.Count == 0)
        {
            return;
        }

        int wordsToHide = Math.Min(numberToHide, availableWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(0, availableWords.Count);
            availableWords[randomIndex].Hide();
            availableWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}