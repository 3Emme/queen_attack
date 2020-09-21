using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    // program code goes here
  }
}

public class Queen
{
  // public properties
  public string TargetQueen { get; set; }
  public string AttackQueen { get; set; }
  public string BoardXLimit { get; set; }
  public string BoardYLimit { get; set; }


  // {x:1,y:1}
  //constructor
  public Queen(string targetQueen, string attackQueen) 
  {
    TargetQueen = targetQueen;
    AttackQueen = attackQueen;
  }

  // public method
  public void SearchAndDestroy()
  {
    
  }

}