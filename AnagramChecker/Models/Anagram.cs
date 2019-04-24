namespace AnagramChecker.Models
{
  public class Anagram
  {

    // properties, methods, etc. will go here.

  }
  [TestMethod]
    public void AnagramCompare_ComparesTwoStrings_true()
    {
      Anagram newAnagram = new Anagram("test");
      Assert.AreEqual("cat", newAnagram.AnagramCompare("cat"));
    }
}
