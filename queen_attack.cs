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
      // if (VictimQueen.X == AttackQueen.Y)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckY()
    {
      // if (VictimQueen.X == AttackQueen.Y)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckNE()
    {
      // if (VictimQueen.X == AttackQueen.Y)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckSE()
    {
      // if (VictimQueen.X == AttackQueen.Y)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckSW()
    {
      // if (VictimQueen.X == AttackQueen.Y)
      // {
      //   ConfirmedHit = true;
      // }
    }
    private void CheckNW()
    {
      // if (VictimQueen.X == AttackQueen.Y)
      // {
      //   ConfirmedHit = true;
      // }
    }
  }
}