using ErrorOr;
using MediatR;
using rixbst.Application.Authentication.Common;

namespace rixbst.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;