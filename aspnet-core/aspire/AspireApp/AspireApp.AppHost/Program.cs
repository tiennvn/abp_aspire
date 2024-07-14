var builder = DistributedApplication.CreateBuilder(args);

//var cache = builder.AddRedis("cache");

var authService = builder.AddProject<Projects.Acme_BookStore_AuthServer>("authservice")
.WithHttpsEndpoint(port: 44322);
var hostApiService = builder.AddProject<Projects.Acme_BookStore_HttpApi_Host>("hostapiservice")
.WithHttpsEndpoint(port: 44312);

builder.AddNpmApp("angular", "../../../../angular");

builder.Build().Run();
