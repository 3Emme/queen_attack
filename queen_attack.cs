using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter coordinates for the QUEEN: ");
    string userInput= Console.ReadLine();
    String[] coords = userInput.Split(' ');
    // Console.WriteLine(coords[0],coords[1]);
    foreach (string x in coords)
    {
      Console.WriteLine(x);
    }
    Console.WriteLine("Enter coordinates for the QUEEN'S VICTIM!: ");
    
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
    // bool ConfirmedHit = false;
  }

  // public method
  // public void SearchAndDestroy()
  // {
  //   CheckX();
  //   CheckY();
  //   CheckNE();
  //   CheckSE();
  //   CheckSW();
  //   CheckNW();
  // }

  // private methods
  // private void CheckX()
  // {
      
  // }
  
  // private void CheckY()
  // {
    
  // }
  // private void CheckNE()
  // {
    
  // }
  // private void CheckSE()
  // {
    
  // }
  // private void CheckSW()
  // {
    
  // }
  // private void CheckNW()
  // {
    
  // }
}