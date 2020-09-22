using System;
using System.Collections.Generic;

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
    public List<int[]> HitPath { get; set; }


    // {x:1,y:1}
    //constructor
    public Game(int queenX, int queenY, int victimX, int victimY, int gameSize ) 
    {
      QueenX = queenX;
      QueenY = queenY;
      VictimX = victimX;
      VictimY = victimY;
      BoardXLimit = gameSize;
      BoardYLimit = gameSize;
      bool ConfirmedHit = false;
      List<int[]> HitPath;
    }

    // public method
    public bool SearchAndDestroy()
    {
      //Console.WriteLine("SEARCH AND DESTROY start");
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
      //Console.WriteLine("CHECK X start");
      if (QueenX == VictimX)
      {
        ConfirmedHit = true;
        Console.WriteLine("HIT X");
      }
    }
    private void CheckY()
    {
      //Console.WriteLine("CHECK Y start");
      if (QueenY == VictimY)
      {
        ConfirmedHit = true;
        Console.WriteLine("HIT Y");
      }
    }
    private void CheckNE()
    {
      //Console.WriteLine("CHECK NE start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      List<int[]> hitPath = new List<int[]> ();
      while (queenPosition[0] <= BoardXLimit && queenPosition[1] <= BoardYLimit)
      {        
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT NE");
          // pass hitPath to print 
          HitPath = hitPath;
          break;
        }
        if ((queenPosition[0] != QueenX) && ConfirmedHit == false)
        {
          int[] ArrayOfCoords = {queenPosition[0],queenPosition[1]};
          hitPath.Add(ArrayOfCoords);
          Console.WriteLine("hitPath add: "+queenPosition[0]+" "+queenPosition[1]);
        }
        queenPosition[0] += 1;
        queenPosition[1] += 1;
      }
    }
    private void CheckSE() 
    {
      //Console.WriteLine("CHECK SE start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      while (queenPosition[0] <= BoardXLimit && queenPosition[1] >= 1)
      {        
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT SE");
        }
        queenPosition[0] += 1;
        queenPosition[1] -= 1;
      }
    }
    private void CheckSW() 
    {
      //Console.WriteLine("CHECK SW start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      while (queenPosition[0] >= 1 && queenPosition[1] >= 1)
      {        
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT SW");
        }
        queenPosition[0] -= 1;
        queenPosition[1] -= 1;
      }
    }
    private void CheckNW() 
    {
      //Console.WriteLine("CHECK NW start");
      int[] queenPosition = {QueenX,QueenY};
      int[] victimPosition = {VictimX,VictimY};
      while (queenPosition[0] >= 1 && queenPosition[1] <= BoardYLimit)
      {        
        if ((queenPosition[0] == victimPosition[0]) && (queenPosition[1] == victimPosition[1])){
          ConfirmedHit = true;
          Console.WriteLine("HIT NW");
        }
        queenPosition[0] -= 1;
        queenPosition[1] += 1;
      }
    }
  }
}