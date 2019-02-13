using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("new");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string strWord = "test";
      Word newWord = new Word(strWord);
      string result = newWord.GetWord();
      Assert.AreEqual(strWord, result);
    }

    [TestMethod]
    public void IsAnagram_EmptyWordEmptyKeyWord_True()
    {
      //Arrange
      Word keyWord = new Word("");
      Word newWord = new Word("");

      //Act
      bool result = newWord.IsAnagram(keyWord);

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void IsAnagram_NotEmptyWordEmptyKeyWord_False()
    {
      //Arrange
      Word keyWord = new Word("");
      Word newWord = new Word("a");

      //Act
      bool result = newWord.IsAnagram(keyWord);

      //Assert
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void IsAnagram_EmptyWordNotEmptyKeyWord_False()
    {
      //Arrange
      Word keyWord = new Word("a");
      Word newWord = new Word("");

      //Act
      bool result = newWord.IsAnagram(keyWord);

      //Assert
      Assert.AreEqual(false, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   // Arrange
    //   List<Item> newList = new List<Item> { };
    //
    //   // Act
    //   List<Item> result = Item.GetAll();
    //
    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    //
    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };
    //
    //   //Act
    //   List<Item> result = Item.GetAll();
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}
