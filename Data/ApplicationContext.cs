using System;
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
            _applicationContext.Users.Add(new User {Login = "admin@gmail.com", Password = "12345", Role = new Role{ RoleName = "Admin"} });
            _applicationContext.Users.Add(new User { Login="user@gmail.com", Password="55555" , Role = new Role{ RoleName = "User"}});
            _applicationContext.SaveChanges();
        }
    }
}