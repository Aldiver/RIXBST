using ErrorOr;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using rixbst.Application.Authentication.Commands.Register;
using rixbst.Application.Common.Behaviors;

namespace rixbst.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        services.AddValidatorsFromAssemblyContaining<RegisterCommandValidator>();
        return services;
    }
}