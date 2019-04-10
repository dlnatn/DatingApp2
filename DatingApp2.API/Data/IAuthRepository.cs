using System.Threading.Tasks;
using DatingApp2.API.Models;

namespace DatingApp2.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register (User user, string password);
         Task<User> Login (string user, string password);
         Task<bool> UserExist(string username);
    }
}