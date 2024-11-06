using BeerModel.Models;

namespace BeerModel.Contracts
{
  public interface IBeerService
  {
    void AddBeer(Beer beer);
    Beer? GetBeer(int id);
    IEnumerable<Beer> GetBeers();
    void RemoveBeer(int id);
    void UpdateBeer(int id, Beer beer);
  }
}