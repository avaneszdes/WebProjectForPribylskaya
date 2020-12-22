using System;
using Data;
using Entityes;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _applicationContext;
        public UserRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public bool Create(User user)
        {
            if (_applicationContext.Users.Find(user) != null)
            {
                _applicationContext.Users.Add(user);
                _applicationContext.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(User user)
        {
            if (_applicationContext.Users.Find(user) != null)
            {
                _applicationContext.Users.Remove(user);
                _applicationContext.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Update(User user)
        {
            _applicationContext.Users.Update(user);
            _applicationContext.SaveChanges();
            return true;
        }
    }
}