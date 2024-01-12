using rixbst.Domain.Entites;

namespace rixbst.Application.Common.Interfaces;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user); 
}