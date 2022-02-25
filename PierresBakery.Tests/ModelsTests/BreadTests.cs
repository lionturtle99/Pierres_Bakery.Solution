using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    Bread testBread = new Bread();
    [TestMethod]
    public void CreateClass_CreateAnInstanceOfAClass_Bread()
    {
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void ReturnCost_GoToIfStatement_Int()
    {
      Assert.AreEqual(20, testBread.CostOfBread(6));
    }
    [TestMethod]
    public void ReturnCost_GoToElseStatement_Int()
    {
      Assert.AreEqual(5, testBread.CostOfBread(1));
    }
  }
}