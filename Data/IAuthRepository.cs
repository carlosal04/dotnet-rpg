using DOTNET_RPG.Models;

namespace DOTNET_RPG.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string usermane, string password);
        Task<bool> UserExists(string usermane);
        
    }
}