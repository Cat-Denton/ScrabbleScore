using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      string stringWord = "za";
      Word newWord = new Word(stringWord);
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]

    public void GetPlayedWord_ReturnsWord_String()
    {
      string playedWord = "za";
      Word newWord = new Word("za");
      string result = newWord.PlayedWord;
      Assert.AreEqual(playedWord,result);
    }

    [TestMethod]

    public void GetScore_ReturnSingleLetterScore_1()
    {
      string test = "A";
      Word newWord = new Word(test);
      int result = newWord.GetScore();
      Assert.AreEqual(1,result);
    }

    [TestMethod]
    public void GetScore_ReturnMultiLetterScore_3()
    {
      string test = "ROT";
      Word newWord = new Word(test);
      int result = newWord.GetScore();
      Assert.AreEqual(3,result);
    }

    [TestMethod]

    public void GetScore_ReturnMultiLetterMultiScore_5()
    {
      string test = "DOG";
      Word newWord = new Word(test);
      int result = newWord.GetScore();
      Assert.AreEqual(5,result);
    }
  }
}