using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetLoaves_ReturnsLoaves_Int()
    {
      int loaf = 5;
      Bread newBread = new Bread(loaf);
      int result = newBread.Loaf;
      Assert.AreEqual(loaf, result);
    }
  }
}