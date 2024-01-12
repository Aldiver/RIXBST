using rixbst.Domain.Entites;

namespace rixbst.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);