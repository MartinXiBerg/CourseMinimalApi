using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRandom.Services
{
  internal class CalculationService : ICalculationService
  {
    public int Sum(int a, int b)
    {
      return a + b;
    }
  }
}
