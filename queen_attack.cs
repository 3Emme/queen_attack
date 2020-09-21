using System;

namespace QueenAttack{
  public class Game
  {
    // public properties
    public object VictimQueen { get; set; }
    public object AttackQueen { get; set; }
    public int BoardXLimit { get; set; }
    public int BoardYLimit { get; set; }
    public bool ConfirmedHit { get; set; }


    // {x:1,y:1}
    //constructor
    public Game(object victimQueen, object attackQueen) 
    {
      VictimQueen = victimQueen;
      AttackQueen = attackQueen;
      bool ConfirmedHit = false;
    }

    // public method
    public bool SearchAndDestroy()
    {
      Console.WriteLine("SEARCH AND DESTROY");
      CheckX();
      CheckY();
      CheckNE();
      CheckSE();
      CheckSW();
      CheckNW();
      return ConfirmedHit;
    }

    // private methods
    private void CheckX()
    {
      Console.WriteLine("CHECK X");
      if (AttackQueen["x"] == VictimQueen["x"])
      {
        ConfirmedHit = true;
        Console.WriteLine("HIT X");
      }
    }
    private void CheckY()
    {
      // if (AttackQueen.yCoord == VictimQueen.yVCoord)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckNE()
    {
      // int distanceToCorner =
      // for (int i = 0, i< )
    }
    private void CheckSE()
    {
      // if (AttackQueen.xCoord == VictimQueen.xVCoord)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckSW()
    {
      // if (AttackQueen.xCoord == VictimQueen.xVCoord)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckNW()
    {
      // if (AttackQueen.xCoord == VictimQueen.xVCoord)
      // {
      //   ConfirmedHit = true;
      // }
    }
  }
}