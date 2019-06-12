using System;

namespace a_whole_new_world
{
  class Program
  {
    static void Main(string[] args)
    {
      var Min = 1;
      var Max = 100;
      var Input = "";
      Console.WriteLine("Pick a number between 1 and 100");
      while (Input != "yes")
      {
        var Guess = ((Min + Max) / 2);
        Console.WriteLine($"Is your number {Guess}?");
        Input = Console.ReadLine();

        if (Input == "no")
        {
          Console.WriteLine("higher or lower");
          Input = Console.ReadLine();
          if (Input == "higher")
          {
            Min = Guess;
          }
          else if (Input == "lower")
          {
            Max = Guess;
          }
        }
      }

      Console.WriteLine("Yay");

    }
  }
}
