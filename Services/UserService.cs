using System;
using Entityes;
using Repositories;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public bool Create(User user)
        {
            return _repository.Create(user);
        }

        public bool Delete(User user)
        {
           return  _repository.Delete(user);
        }

        public bool ChangePasswordOrLogin(User user)
        {
                return _repository.Update(user);
        }
    }
}