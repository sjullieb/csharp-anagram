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
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   string result = newItem.GetDescription();
    //   Assert.AreEqual(description, result);
    // }
    //
    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //
    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newItem.SetDescription(updatedDescription);
    //   string result = newItem.GetDescription();
    //
    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }
    //
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
