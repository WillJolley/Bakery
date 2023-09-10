using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System; 

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstancesOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastries_ReturnsPastries_Int()
    {
      int unit = 3;
      Pastry newPastry = new Pastry(unit);
      int result = newPastry.Unit;
      Assert.AreEqual(unit, result);
    }
  }
}