using rixbst.Domain.Users;

namespace rixbst.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}