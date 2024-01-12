using Microsoft.AspNetCore.Mvc.Infrastructure;
using rixbst.Api.Common.Errors;
using rixbst.Application;
using rixbst.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
// builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
builder.Services.AddControllers();

builder.Services.AddSingleton<ProblemDetailsFactory, RixbstDefaultProblemDetailsFactory>();

var app = builder.Build();

// app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseExceptionHandler("/errors");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
