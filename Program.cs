using System;
using System.Collections.Generic;

namespace Queen {
    class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter coordinates for the QUEEN: ");
      string userInput= Console.ReadLine();
      String[] coords = userInput.Split(' ');
      // check if it was only 2 numbers! 
      int xCoord = int.Parse(coords[0]);
      int xCoord = int.Parse(coords[1]);
      Dictionary<string, int> attackQueenCoords = new Dictionary<string, int>() {{"x",xCoord}, {"y",yCoord}};
      Console.WriteLine(attackQueenCoords);

      // Console.WriteLine(coords[0],coords[1]);
      // foreach (string x in coords)
      // {
      //   Console.WriteLine(x);
      // }
      
      // Console.WriteLine("Enter coordinates for the QUEEN'S VICTIM!: ");
      
    }
  }
}

