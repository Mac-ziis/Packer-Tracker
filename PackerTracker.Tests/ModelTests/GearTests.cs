using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class GearTests
  {

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
    
  }
}