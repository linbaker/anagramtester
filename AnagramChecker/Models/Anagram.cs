using System;
using System.Collections.Generic;

namespace AnagramChecker.Models
{
  public class Anagram
  {

    private string _word;

    public Anagram (string word)
    {
      _word = word;

    }

    // public string GetWord()
    // {
    //   return _word;
    // }
    //
    // public string AnagramTransform(string word)
    // {
    //   char[] wordInput = word.ToCharArray();
    //   Array.Sort(wordInput);
    //   string sortedWord = new string(wordInput);
    // }
  }
}
