namespace BeerModel.EndpointFilters;

public class LoggingEndpointFilter :IEndpointFilter
{
  public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
  {
    var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<LoggingEndpointFilter>>();
    logger.LogInformation($"Executing endpoint: {context.HttpContext.Request.Method}|{context.HttpContext.Request.Path}");

    var result = await next(context);

    logger.LogInformation($"Executed endpoint: {context.HttpContext.Request.Method}|{context.HttpContext.Request.Path}");
    return result;
  }
}
