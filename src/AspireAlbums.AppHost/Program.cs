var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.AspireAlbums_AlbumApi>("albumapi");

builder.AddProject<Projects.AspireAlbums_AlbumUI>("albumui")
    .WithExternalHttpEndpoints()
    .WithReference(apiservice);

builder.Build().Run();
