using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System.Collections.Generic;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void PlayGameMethod_CreateDictionary_Dictionary()
    {
      // testing code will go here
      Game testGame = new Game();
      string gamePlay = testGame.PlayGame("rock", "scissors");
      string _testingOutput = "Player 1 wins!";
      Assert.AreEqual(_testingOutput, gamePlay);
    }
  }
}