using System;
using System.Collections.Generic;
namespace Anagram.Models
{
  public class Word
  {
    private string _word;

    public Word(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    private char[] SplitToArrayAndSort()
    {
      char[] wordArray = (_word.ToUpper()).ToCharArray();
      Array.Sort(wordArray);
      return wordArray;
    }

    public bool IsAnagram(Word otherWord)
    {
      char[] thisWordArray = SplitToArrayAndSort();
      char[] otherWordArray = otherWord.SplitToArrayAndSort();

      if (thisWordArray.Length != otherWordArray.Length)
        return false;

      for (int i = 0; i < thisWordArray.Length; i++)
          if (thisWordArray[i] != otherWordArray[i])
            return false;

      return true;
    }
    public bool IsPartialAnagram(Word otherWord)
    {
      char[] thisWordArray = SplitToArrayAndSort();
      char[] otherWordArray = otherWord.SplitToArrayAndSort();

      bool result = false;
      if (thisWordArray.Length <= otherWordArray.Length)
      {
        result = true;
        int j = 0;
        int matchingLettersCount = 0;
        for (int i = 0; i < thisWordArray.Length; i++)
        {
          while((j < otherWordArray.Length) && (thisWordArray[i] != otherWordArray[j]))
          {
            j++;
          }
          if (j >= otherWordArray.Length)
          {
            return false;
          }
          else if (thisWordArray[i] == otherWordArray[j])
          {
            matchingLettersCount++;
            j++;
          }
        }
        if(matchingLettersCount != thisWordArray.Length)
          return false;
      }
      return result;
    }
  }

}
