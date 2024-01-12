using Mapster;
using rixbst.Application.Authentication.Commands.Register;
using rixbst.Application.Authentication.Common;
using rixbst.Application.Authentication.Queries.Login;
using rixbst.Contracts.Authentication;

namespace rixbst.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        
        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}