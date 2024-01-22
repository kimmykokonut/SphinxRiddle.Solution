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
  }
  
}