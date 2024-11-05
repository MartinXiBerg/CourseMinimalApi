using BeerStore.Contracts;
using BeerStore.EndpointFilters;
using BeerStore.Models;

namespace BeerStore.Endpoints;

internal static class BeerEndpoint
{
  public static void MapBeersEndpoints(this IEndpointRouteBuilder routes)
  {
    var group = routes.MapGroup("/beers")
        //.WithGroupName("Beer endpoints")
        //.AddEndpointFilter<LoggingEndpointFilter>()         // Add logging to all Beer endpoints (in this group)
        //.AddEndpointFilter<ErrorHandlingEndpointFilter>()
        ;

    group.MapGet("/", (IBeerService BeerService) =>
    {
      return Results.Ok(BeerService.GetBeers());
    })
.AddEndpointFilter<LoggingEndpointFilter>()  // logging

      ;
    group.MapGet("/{id}", (int id, IBeerService BeerService) =>
    {
      var Beer = BeerService.GetBeer(id);
      return Beer is null
          ? Results.NotFound()
          : Results.Ok(Beer);
    })
.AddEndpointFilter<LoggingEndpointFilter>()  // logging      
      ;
    group.MapPost("/", (Beer Beer, IBeerService BeerService) =>
    {
      BeerService.AddBeer(Beer);
      return Results.Created($"/Beers/{Beer.Id}", Beer);
    })
    .AddEndpointFilter<LoggingEndpointFilter>()  // logging
    .AddEndpointFilter<ValidFilter>()  // logging
    ;
    group.MapPut("/{id}", (Beer Beer, int id, IBeerService BeerService) =>
    {
      BeerService.UpdateBeer(id, Beer);
      return Results.Ok(Beer);
    })
    .AddEndpointFilter<LoggingEndpointFilter>()  // logging
    .AddEndpointFilter<ValidFilter>()  // logging
    ;  // Validate the Beer argument
    group.MapDelete("/{id}", (int id, IBeerService BeerService) =>
    {
      BeerService.RemoveBeer(id);
      return Results.NoContent();
    })
    .AddEndpointFilter<LoggingEndpointFilter>()  // logging      
      ;

  }
}
