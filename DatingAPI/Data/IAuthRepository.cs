using System.Threading.Tasks;
using DatingAPI.Models;

namespace DatingAPI.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> LogIn(string user, string password);

         Task<bool> UserExist(string user);
    }
}