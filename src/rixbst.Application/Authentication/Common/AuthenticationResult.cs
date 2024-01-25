using rixbst.Domain.Users;

namespace rixbst.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);