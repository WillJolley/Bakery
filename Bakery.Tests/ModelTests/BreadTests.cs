using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
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

    [TestMethod]
    public void SetLoaves_SetsValueOfLoaf_Void()
    {
      Bread newBread = new Bread(2);
      int newLoaf = 7;
      newBread.Loaf = newLoaf;
      Assert.AreEqual(newLoaf, newBread.Loaf);
    }

    [TestMethod]
    public void GetBreadCost_ReturnsBreadCost_Int()
    {
      Bread newBread = new Bread(3);
      newBread.BreadCost = 0;
    }

    [TestMethod]
    public void CalcCost_CalculatesCostOfBread_Int()
    {
      Bread newBread = new Bread(9);
      newBread.CalcCost();
      newBread.BreadCost = 40;
    }
  }
}