using BeerModel.Contracts;
using BeerModel.Models;

namespace BeerModel.Services
{
  public class BeerService : IBeerService
  {
    private static int iIndex = 0;

    private readonly List<Beer> _beers = [];

    public IEnumerable<Beer> GetBeers() => _beers;

    public Beer? GetBeer(int id) => _beers.FirstOrDefault(beer => beer.Id == id) ;

    public void AddBeer(Beer beer)
    {
      beer.Id = iIndex++;
      _beers.Add(beer);
    }
    public void UpdateBeer(int id, Beer beer)
    {
      beer.Id = id;
      int idx = _beers.FindIndex(beer => beer.Id == id);
      if (idx == -1)
      {
        return;
      }
      _beers[idx] = beer;
    }

    public void RemoveBeer(int id)
    {
      int idx = _beers.FindIndex(beer => beer.Id == id);
      if (idx == -1)
      {
        return;
      }
      _beers.RemoveAt(idx);
    }

  }
}
