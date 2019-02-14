using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an initial world:");
      string input = Console.ReadLine();
      Word keyWord = new Word(input);

      List<Word> allWords = new List<Word>{};
      do {
        Console.WriteLine("Enter a word to check if it's an anagram of '" + input + "':");

        Word newWord = new Word(Console.ReadLine());
        allWords.Add(newWord);

        Console.WriteLine("Would you like to check more words? [Y] for Yes/any other for No");
      } while (Console.ReadLine().ToUpper() == "Y");

      string result = "";
      foreach(Word oneWord in allWords)
      {
        if (oneWord.IsAnagram(keyWord))
        {
          result = oneWord.GetWord() + " is an anagram.";
        }
        else if (oneWord.IsPartialAnagram(keyWord))
        {
          result = oneWord.GetWord() + " is a partial anagram.";
        }
        else
        {
          result = oneWord.GetWord() + " is NOT an anagram.";
        }
        Console.WriteLine(result);
      }

    }
  }
}
