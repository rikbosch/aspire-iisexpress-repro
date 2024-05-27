var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject("webapp", @"..\WebApplication1\WebApplication1.csproj", "IIS Express");

builder.Build().Run();
