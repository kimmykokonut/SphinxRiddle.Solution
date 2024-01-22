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
      Riddle newRiddle = new Riddle("hello");
      Assert.AreEqual(typeof(Riddle), newRiddle.GetType());
    }

    [TestMethod]
    public void GetInput_ReturnsInput_String()
    {
      string userInput = "Test";
      Riddle newRiddle = new Riddle(userInput);
      string result = newRiddle.Input;
      Assert.AreEqual(userInput, result);
    }

    [TestMethod]
    public void SetInput_SetsValue_Void()
    {
      Riddle newRiddle = new Riddle("Test");
      string newAnswer = "Updated Test";
      newRiddle.Input = newAnswer;
      Assert.AreEqual(newAnswer, newRiddle.Input);
    }
    [TestMethod]
    public void CheckAnswer_DeterminesIfUserAnswerMatchesActualAnswer_Bool()
    {
        Riddle newRiddle = new Riddle("test answer");
        bool riddleTest = newRiddle.CheckAnswer("test answer", "actual answer");
        Assert.IsInstanceOfType(riddleTest, typeof(bool));
        Assert.IsFalse(riddleTest);
    }
  }
}