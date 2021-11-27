using MinimalJwt.Models;

namespace MinimalJwt.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
