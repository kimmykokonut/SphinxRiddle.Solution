using System;

namespace SphinxRiddle.Models
{
  public class Riddle
  {
    public string Input { get; set; }

    public Riddle(string userInput)
  {
    Input = userInput;
    // Answer= answer; //A1 = "memory"
  }
    public bool CheckAnswer(string userInput)
    {
        string answer = "memory";
        if (userInput == answer)
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