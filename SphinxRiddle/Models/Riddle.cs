using System;

namespace SphinxRiddle.Models
{
  public class Riddle
  {
    public string Input { get; set; }

    public Riddle(string userInput)
  {
    Input = userInput;
  }
    public bool CheckAnswer(string input, string answer)
    {
        if (input == answer)
        {
            return true;
        }
        else 
        {
            return false;

        }
    }

  }
  
}