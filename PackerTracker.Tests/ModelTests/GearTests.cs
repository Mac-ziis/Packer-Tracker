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
    
  }
}