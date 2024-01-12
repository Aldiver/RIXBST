using rixbst.Api;
using rixbst.Application;
using rixbst.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
builder.Services
    .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
app.UseExceptionHandler("/errors");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
}