var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorWithAspire>("blazorwithaspire");

builder.Build().Run();
