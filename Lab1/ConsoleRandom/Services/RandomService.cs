using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRandom.Services
{
  internal class RandomService : IRandomService
  {
    public int GetRandom()
    {
      Random random = new Random();

      // Generate a random integer
      //int randomNumber = random.Next();
      //Console.WriteLine($"Random Number: {randomNumber}");

      // Generate a random integer between 0 and 100
      int randomInRange = random.Next(0, 101);
      return randomInRange;
    }
  }
}
