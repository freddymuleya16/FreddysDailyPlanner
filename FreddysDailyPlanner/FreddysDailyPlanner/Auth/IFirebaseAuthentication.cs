using System.Threading.Tasks;
using FreddysDailyPlanner.Models;

namespace FreddysDailyPlanner.Auth
{
    public interface IFirebaseAuthentication
    {
        Task<UserModel> LoginWithEmailAndPassword(string email, string password);
        Task<bool> RegisterWithEmailAndPassword(string username, string email, string password);
        Task ForgetPassword(string email);
        string GetUsername();
        string GetUserId();
        bool IsLoggedIn();
        bool LogOut();
    }
}
