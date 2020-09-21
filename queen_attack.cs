using System;

namespace QueenAttack{
  public class Game
  {
    // public properties
    public int QueenX { get; set; }
    public int QueenY { get; set; }
    public int VictimX { get; set; }
    public int VictimY { get; set; }
    public int BoardXLimit { get; set; }
    public int BoardYLimit { get; set; }
    public bool ConfirmedHit { get; set; }


    // {x:1,y:1}
    //constructor
    public Game(int queenX, int queenY, int victimX, int victimY ) 
    {
      QueenX = queenX;
      QueenY = queenY;
      VictimX = victimX;
      VictimY = victimY;
      bool ConfirmedHit = false;
    }

    // public method
    public bool SearchAndDestroy()
    {
      Console.WriteLine("SEARCH AND DESTROY start");
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
      Console.WriteLine("CHECK X start");
      if (QueenX == VictimX)
      {
        ConfirmedHit = true;
        Console.WriteLine("HIT X");
      }
    }
    private void CheckY()
    {
      Console.WriteLine("CHECK Y start");
      if (QueenY == VictimY)
      {
        ConfirmedHit = true;
        Console.WriteLine("HIT Y");
      }
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