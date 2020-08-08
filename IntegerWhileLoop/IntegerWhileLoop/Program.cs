﻿using System;
using System.Reflection.Metadata;

namespace IntegerWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        // This program will prompt the user for an integer and continue prompting until an integer between 1 and 10 is entered.
        // Use a while loop

        // Initialize
        Boolean inputAcceptable = false;

        // user input
        while (inputAcceptable != true)
        {
          // Do stuff
          Console.WriteLine("Please input an integer between 1 and 10.");

          string userStringInput = Console.ReadLine();
          int userInput = 0;

          int value;
          if (int.TryParse(userStringInput, out value))
          {
            userInput = Convert.ToInt32(userStringInput);
          }
          else
          {
            throw new Exception("Expected a value between 1 and 10.");
          }

          if (userInput <= 10 && userInput >= 1)
          {
            inputAcceptable = true;
            Console.WriteLine("Thank you.");
          }
          else
          {
            Console.WriteLine("That number is not between 1 and 10!");
          }
        }
      }

      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
