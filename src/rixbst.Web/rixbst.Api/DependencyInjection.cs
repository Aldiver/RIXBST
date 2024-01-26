
using Microsoft.AspNetCore.Mvc.Infrastructure;
using rixbst.Api.Common.Errors;
using rixbst.Api.Common.Mapping;

namespace rixbst.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, RixbstDefaultProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}