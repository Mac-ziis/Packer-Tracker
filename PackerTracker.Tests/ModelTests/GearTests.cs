using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class GearTests : IDisposable
  {
    public void Dispose()
    {
      Gear.ClearAll();
    }

    [TestMethod]
    public void GearConstructor_CreatesInstanceOfGear_Gear()
    {
      string gearName = "Boots";
      Gear newGear = new Gear(gearName);
      Assert.AreEqual(typeof(Gear), newGear.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Use red backpack.";

      //Act
      Gear newGear = new Gear(description);
      string result = newGear.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Running Shoes with white stripes.";
      Gear newGear = new Gear(description);

      //Act
      string updatedDescription = "White striped running shoes.";
      newGear.Description = updatedDescription;
      string result = newGear.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_GearList()
    {
      // Arrange
      List<Gear> newList = new List<Gear> { };
      // Act
      List<Gear> result = Gear.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod] //
    public void GetAll_ReturnsGears_GearList()
    {
      //Arrange
      string description01 = "Pack the sleeping pad.";
      string description02 = "Get fuel for the camp stove.";
      Gear newGear1 = new Gear(description01);
      Gear newGear2 = new Gear(description02);
      List<Gear> newList = new List<Gear> { newGear1, newGear2 };
      // Act
      List<Gear> result = Gear.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterResturn_Int()
    {
      //Arrange
      string description = "Camp stove";
      Gear newGear = new Gear(description);

      //Act
      int result = newGear.Id;

      //Assert
      Assert.AreEqual(1, result);

    }
  }
}