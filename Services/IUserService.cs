using Entityes;

namespace Services
{
    public interface IUserService
    {
        bool Create(User user);
        
        bool Delete(User user);

        bool ChangePasswordOrLogin(User user);
    }
}