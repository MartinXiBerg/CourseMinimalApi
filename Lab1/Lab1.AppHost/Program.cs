var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireExample>("aspireexample");

builder.Build().Run();
