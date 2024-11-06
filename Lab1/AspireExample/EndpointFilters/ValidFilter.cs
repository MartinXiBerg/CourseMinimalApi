using BeerModel.Models;

namespace BeerModel.EndpointFilters;


public class ValidFilter : IEndpointFilter
{
  public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
  {
    var beer = context.Arguments.OfType<Beer>().FirstOrDefault();  // less efficient, but more generic than GetArgument
    // before
    //var book = context.GetArgument<Beer>(0);

    if (beer is null)
    {
      return Results.BadRequest("Book is required");
    }

    if (beer.Name is null || beer.Name.Length < 3 || beer.Name.Length > 255)
    {
      return Results.BadRequest("Title must be between 3 and 255 characters");
    }

    if (beer.Taste is null || beer.Taste.Length < 3 || beer.Taste.Length > 255)
    {
      return Results.BadRequest("Author must be between 3 and 255 characters");
    }

    // TODO: check if id if present

    var result = await next(context);
    // after
    return result;
  }
}
