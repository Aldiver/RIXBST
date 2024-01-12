using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rixbst.Application.Common.Interfaces;
using rixbst.Application.Common.Interfaces.Authentication;
using rixbst.Application.Common.Interfaces.Services;
using rixbst.Infrastructure.Authentication;
using rixbst.Infrastructure.Persistence;
using rixbst.Infrastructure.Services;

namespace rixbst.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
    ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}