using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Models
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("WELCOME TO THE GREATEST GAME EVER MADE.");
      Console.WriteLine("Player 1, choose you weapon. Rock, Paper, or Scissors: ");
      string player1Selection = Console.ReadLine().ToLower();
      Console.WriteLine("Player 2, choose you weapon. Rock, Paper, or Scissors: ");
      string player2Selection = Console.ReadLine().ToLower();

      if (player1Selection == player2Selection)
      {
        player1Selection = player1Selection + "1";
      }
      
      Game mainGame = new Game();
      string output = mainGame.PlayGame(player1Selection, player2Selection);
      Console.WriteLine(output);
    }
  }
}