using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string PlayGame(string player1Selection, string player2Selection)
    {
      Dictionary<string, string> _selections = new Dictionary<string, string>() { { player1Selection, "1" }, { player2Selection, "2" } };

      string Winner = "";
        if (_selections.ContainsKey("rock") && _selections.ContainsKey("scissors")) 
        {
          Winner = "Player " + _selections["rock"] + " wins!"; 
        }

        if (_selections.ContainsKey("rock") && _selections.ContainsKey("paper")) 
        {
          Winner = "Player " + _selections["paper"] + " wins!"; 
        }

        if (_selections.ContainsKey("scissors") && _selections.ContainsKey("paper")) 
        {
          Winner = "Player " + _selections["scissors"] + " wins!"; 
        }

        if (_selections.ElementAt(0).Key ==  (_selections.ElementAt(1).Key + "1"))
        {
          Winner = "It's a tie!";
        }

        return Winner;
        }
  }
}

