using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    Pastry testPastry = new Pastry();
    [TestMethod]
  public void CreateClass_CreateAnInstanceOfAClass_Pastry()
    {
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    } 
    [TestMethod]
    public void ReturnCost_GoToIfStatement_Int()
    {
      Assert.AreEqual(10, testPastry.CostOfPastry(6));
    }
    [TestMethod]
    public void ReturnCost_GoToElseStatement_Int()
    {
      Assert.AreEqual(4, testPastry.CostOfPastry(2));
    }
  }
}