using System;
using System.Linq;
using Entityes;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public void AddUser(ApplicationContext _applicationContext)
        {
            var user1 = new User
                {Login = "admin@gmail.com", Password = "12345", Role = new Role {RoleName = "Admin"}};
            var user2 = new User
                {Login = "user@gmail.com", Password = "55555", Role = new Role {RoleName = "User"}};

            if (!_applicationContext.Users.Any())
            { 
                _applicationContext.Users.AddRange(user1,user2);
                _applicationContext.SaveChanges();
                
            }
            
        }
    }
}