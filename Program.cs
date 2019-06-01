using System;

namespace BranchesAndLoops
{
  class Program
  {
    static void ExploreIf()
    {
      int a = 5;
      int b = 6;
      if (a + b > 10)
      {
        Console.WriteLine("The answer is greater than 10.");
      }
      else
      {
        Console.WriteLine("The answer is NOT greater than 10");
      }

      int c = 4;
      if ((a + b + c > 10) && (a == b))
      {
        Console.WriteLine("The answer is great than 10");
        Console.WriteLine("And the first number is equal to the second");
      }
      else
      {
        Console.WriteLine("The answer is NOT greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
      }

      if ((a + b + c > 10) || (a == b))
      {
        Console.WriteLine("The answer is great than 10");
        Console.WriteLine("OR the first number is equal to the second");
      }
      else
      {
        Console.WriteLine("The answer is NOT greater than 10");
        Console.WriteLine("AND the first number is not equal to the second");
      }
    }

    static void Loopy()
    {
      // While Loop
      int counter = 0;
      while (counter < 10)
      {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
      }

      // Do While loop
      counter = 0;
      do
      {
        Console.WriteLine($"Hello World! The counter is {counter} and I'm a do while Loop!");
        counter++;
      } while (counter < 10);

      // For Loop
      for (int index = 0; index < 10; index++)
      {
        Console.WriteLine($"Hello WOrld! The index is {index}");
      }
    }

    static void ConditionalSummation()
    {
      int accum = 0;
      for (int i = 1; i <= 20; i++)
      {
        if (i % 3 == 0)
        {
          accum = accum + i;
        }
      }
      Console.WriteLine($"The sum of all integers 1 through 20 divisible by 3 is {accum}!");
    }

    static void Main(string[] args)
    {
      ExploreIf();
      Loopy();
      ConditionalSummation();
    }
  }
}
