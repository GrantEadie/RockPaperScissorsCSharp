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
      Console.WriteLine("Would you like to play against the computer? Type 'y' for yes, 'n' for no.");
      string choice = Console.ReadLine().ToLower();

      string player1Selection = "";
      string player2Selection = "";

      if (choice == "y")
      {
        Console.WriteLine("Player 1, choose you weapon. Rock, Paper, or Scissors: ");
        player1Selection = Console.ReadLine().ToLower();
        Random rnd = new Random();
        int computer = rnd.Next(1, 4);
        if (computer == 1)
        {
          player2Selection = "rock";
        }
        else if (computer == 2)
        {
          player2Selection = "scissors";
        }
        else 
        {
          player2Selection = "paper";
        }
        Console.WriteLine("Computer chose: " + player2Selection);
      }
      else
      {
        Console.WriteLine("Player 1, choose you weapon. Rock, Paper, or Scissors: ");
        player1Selection = Console.ReadLine().ToLower();
        Console.WriteLine("Player 2, choose you weapon. Rock, Paper, or Scissors: ");
        player2Selection = Console.ReadLine().ToLower();
      }

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