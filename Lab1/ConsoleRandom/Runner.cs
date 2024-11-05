using ConsoleRandom.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRandom
{
  internal class Runner
  {
    private readonly ICalculationService _calculatorService;
    private readonly IRandomService _randomService;

    public Runner(ICalculationService calculatorService, IRandomService randomService)
    {
      _calculatorService = calculatorService;
      _randomService = randomService;
    }

    public void Run()
    {
      int iFirst = _randomService.GetRandom();
      int iLast = _randomService.GetRandom();

      int iResult = _calculatorService.Sum(iLast, iFirst);

      Console.WriteLine($"Rand 1: {iFirst} Rand 2: {iLast} Sum: {iResult}");

    }
  }
}
