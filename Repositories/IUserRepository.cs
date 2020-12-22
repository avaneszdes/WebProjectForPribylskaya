using Entityes;

namespace Repositories
{
    public interface IUserRepository
    {
        bool Create(User user);
        bool Delete(User user);
        bool Update(User user);

    }
}