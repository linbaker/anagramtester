using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;

namespace AnagramChecker.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      Anagram newAnagram = new Anagram("test");
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }
    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string word = "cat";
      Anagram newAnagram = new Anagram(word);

      string result = newAnagram.GetWord();

      Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void SetWord_SetWord_String()
    {
      //Arrange
      string word = "cat";
      Anagram newAnagram = new Anagram(word);

      //Act
      string updatedWord = "act";
      newAnagram.SetWord(updatedWord);
      string result = newAnagram.GetWord();

      //Assert
      Assert.AreEqual(updatedWord, result);
    }
    [TestMethod]
    public void AnagramTransform_SortWord_String()
    {
      //Arrange
      string word = "cat";
      Anagram newAnagram = new Anagram(word);

      //Act
      // newAnagram.AnagramTransform(word);
      // string result = newAnagram.GetWord();

      //Assert
      Assert.AreEqual("act", word.AnagramTransform("cat"));
    }
  }
}
