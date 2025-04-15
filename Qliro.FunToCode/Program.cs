using Qliro.FunToCode.Configuration.Endpoints;
using Qliro.FunToCode.Infrastructure.Persistence;
using Qliro.FunToCode.Infrastructure.Processing;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddOpenApi();

builder.Services.AddPersistenceModule();
builder.Services.AddProcessingModule();

var app = builder.Build();

app.MapEndpoints();

if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
  app.MapScalarApiReference("/");
}

app.Run();