var builder = DistributedApplication.CreateBuilder(args);

var service = builder.AddProject<Projects.AspireExample>("aspireexample");
builder.AddProject<Projects.ViewerOfBeer>("viewerofbeer")
    .WithReference(service);
    


builder.Build().Run();
