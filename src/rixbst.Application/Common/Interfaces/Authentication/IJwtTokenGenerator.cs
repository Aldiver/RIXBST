using rixbst.Domain.Entites;

namespace rixbst.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}