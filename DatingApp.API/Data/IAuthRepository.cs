using System.Threading.Tasks;
using DatingApp.API.Model;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        //27 th clip
         Task<User> Register(User user,string password);
         Task<User> Login(string username , string password);
         Task<bool> UserExists(string username);            
         
     }
}