using rixbst.Domain.Users;

namespace rixbst.Application.Common.Interfaces;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user); 
}