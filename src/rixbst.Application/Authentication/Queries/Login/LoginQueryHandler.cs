using ErrorOr;
using MediatR;
using rixbst.Application.Common.Interfaces;
using rixbst.Application.Common.Interfaces.Authentication;
using rixbst.Domain.Entites;
using rixbst.Domain.Common.Errors;
using rixbst.Application.Authentication.Common;

namespace rixbst.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        // validate user exist
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        //validate password
        if (user.Password != query.Password)
        {
            return new [] { Errors.Authentication.InvalidCredentials };
        }

        //generate jwt token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
            );
    }
}