
using BeerModel.Models;

namespace ViewerOfBeer.Services;


public class ApiClient(HttpClient http)
{
  private const string cstrRequestUri = "/beers";



  /// <summary>
  /// A client for the API (manually created).
  /// </summary>
  /// <param name="http"></param>

  public async Task<List<Beer>> GetBeerAsync(CancellationToken cancellationToken = default)
  {
    return await http.GetFromJsonAsync<List<Beer>>(cstrRequestUri, cancellationToken) ?? [];
  }

  public async Task SetNewBeer(CancellationToken cancellationToken = default)
  {
    Beer beer = new() { Name = "Wieselburger", Taste = "sehr gut" };

    await http.PostAsJsonAsync<Beer>(cstrRequestUri, beer, cancellationToken);
    
    
    
  }

  public async Task SetMyBeer(Beer beer, CancellationToken cancellationToken = default)
  {
    //Beer beer = new() { Name = "Wieselburger", Taste = "sehr gut" };

    await http.PostAsJsonAsync<Beer>(cstrRequestUri, beer, cancellationToken);



  }


}
