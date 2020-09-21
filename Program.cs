using System;
using System.Collections.Generic;

namespace QueenAttack{
    class Program
  {
    public static void Main()
    {
      // INPUT FOR QUEEN'S COORDINATES
      Console.WriteLine("Enter coordinates for the ATTACK QUEEN: ");
      string userInput= Console.ReadLine();
      String[] coords = userInput.Split(' ');
      // check if it was only 2 numbers! 
      int xCoord = int.Parse(coords[0]);
      int yCoord = int.Parse(coords[1]);
      Dictionary<string, int> attackQueenCoords = new Dictionary<string, int>() {{"x",xCoord}, {"y",yCoord}};
      Console.WriteLine(attackQueenCoords["x"].ToString());
      Console.WriteLine(attackQueenCoords["y"].ToString());
      // INPUT FOR QUEEN'S VICTIM
      Console.WriteLine("Enter coordinates for the QUEEN's VICTIM: ");
      string userInput2= Console.ReadLine();
      String[] vCoords = userInput2.Split(' ');
      // check if it was only 2 numbers! 
      int xVCoord = int.Parse(vCoords[0]);
      int yVCoord = int.Parse(vCoords[1]);
      Dictionary<string, int> victimCoords = new Dictionary<string, int>() {{"x",xVCoord}, {"y",yVCoord}};
      Console.WriteLine(victimCoords["x"].ToString());
      Console.WriteLine(victimCoords["y"].ToString());
      // if queen coords = victum coords then alert! 
      Game queen = new Game(attackQueenCoords,victimCoords);
      queen.SearchAndDestroy();

    }
  }
}

