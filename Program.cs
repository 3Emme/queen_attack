using System;
using System.Collections.Generic;

namespace QueenAttack{
    class Program
  {
    public static void PrintMap(string[][] masterArray)
      {
        foreach (string[] array in masterArray) 
        {
          string mapLine = string.Join("  ",array);
          Console.WriteLine(mapLine);
        }
      }
    public static void Main()
    {

      Console.WriteLine("Enter a number for the size of the game board: ");
      string sizeInput= Console.ReadLine();
      int gameSize = int.Parse(sizeInput);

      // CREATE MAP!      
      string[][] masterArray = new string[gameSize][]; // Y axis set
      for (int i=0;i<gameSize;i++) // X axis set
      {
        masterArray[i] = new string[gameSize];
      }
      // FILL OUT MAP WITH 0's
      foreach (string[] array in masterArray) 
      {
        for (int i=0;i<array.Length;i++) 
        {
          array[i] = "0";          
        } 
      }
      PrintMap(masterArray);



      // int mapsize = 0;
      // string[][] masterArray = new string[gameSize][]; // Y axis set
      // for (int i=0;i<gameSize;i++) // X axis set
      // {
      //   masterArray[i] = new string[gameSize];
      // }
      // foreach (string[] array in masterArray) {
      //   for (int i=0;i<array.Length;i++) {
      //     array[i] = "0";
      //     //Console.WriteLine(array[i]);
      //   } 
      //   string mapLine = string.Join("  ",array);
      //   Console.WriteLine(mapLine);
      // }
  


    
      // INPUT FOR QUEEN'S COORDINATES
      Console.WriteLine("Enter coordinates for the ATTACK QUEEN: ");
      string userInput= Console.ReadLine();
      String[] coords = userInput.Split(' ');

      // check if it was only 2 numbers! 
      int xCoord = int.Parse(coords[0]);
      int yCoord = int.Parse(coords[1]);

      
      // INPUT FOR QUEEN'S VICTIM
      Console.WriteLine("Enter coordinates for the QUEEN's VICTIM: ");
      string userInput2= Console.ReadLine();
      String[] vCoords = userInput2.Split(' ');

      // check if it was only 2 numbers! 
      int xVCoord = int.Parse(vCoords[0]);
      int yVCoord = int.Parse(vCoords[1]);


      
      Game queen = new Game(xCoord,yCoord,xVCoord,yVCoord,gameSize);
      if (queen.SearchAndDestroy()) {
        Console.WriteLine("------------------------");
        Console.WriteLine("-                      -");
        Console.WriteLine("-  Queen scored a HIT  -");
        Console.WriteLine("-                      -");
        Console.WriteLine("------------------------");
      }

    }
  }
}

