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
      BoardXLimit = 8;
      BoardYLimit = 8;
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
      Console.WriteLine("CHECK NE start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      while (queenPosition[0] <= BoardXLimit && queenPosition[1] <= BoardYLimit)
      {
        Console.WriteLine(queenPosition[0]);
        Console.WriteLine(queenPosition[1]);
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT NE");
        }
        queenPosition[0] += 1;
        queenPosition[1] += 1;
      }
    }
    private void CheckSE() // x 8 y 1
    {
      Console.WriteLine("CHECK SE start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      while (queenPosition[0] <= BoardXLimit && queenPosition[1] >= 1)
      {
        Console.WriteLine(queenPosition[0]);
        Console.WriteLine(queenPosition[1]);
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT SE");
        }
        queenPosition[0] += 1;
        queenPosition[1] -= 1;
      }
    }
    private void CheckSW() // x 1 y 1
    {
      Console.WriteLine("CHECK SW start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      while (queenPosition[0] >= 1 && queenPosition[1] >= 1)
      {
        Console.WriteLine(queenPosition[0]);
        Console.WriteLine(queenPosition[1]);
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT SW");
        }
        queenPosition[0] -= 1;
        queenPosition[1] -= 1;
      }
    }
    private void CheckNW() // x 1 y 8 
    {
      
    }
  }
}