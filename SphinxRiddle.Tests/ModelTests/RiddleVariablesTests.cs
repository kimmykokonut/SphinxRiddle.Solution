using Microsoft.VisualStudio.TestTools.UnitTesting;
using SphinxRiddle.Models;

namespace SphinxRiddle.Tests
{
  [TestClass]
  public class RiddleTests
  {
    [TestMethod]
    public void RiddleConstructor_CreatesInstanceOfRiddle_Riddle()
    {
      Riddle newRiddle = new Riddle();
      Assert.AreEqual(typeof(Riddle), newRiddle.GetType());
    }
  }
}