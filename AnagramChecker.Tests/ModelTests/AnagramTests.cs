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
  }
}
