using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Repository;
using RV.Views.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace RV.Repositories.SQLRepositories
{
    public class SQLUserRepository : IUserRepository
    {
        private ApplicationContext _dbContext;

        public SQLUserRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User CreateUser(User item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();      
            return item;
        }

        public int DeleteUser(int id)
        {
            int res = _dbContext.Users.Where(u => u.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public User GetUser(int id)
        {
            var res = _dbContext.Users.Where(u => u.id == id).ToList();
            User u;
            if (res.Count > 0)
            {
                u = res[0];
                return u;
            }
            else return null;
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User UpdateUser(User item)
        {
            var res = _dbContext.Users.Where(u => u.id == item.id).ToList();
            User u;
            if (res.Count > 0)
            {
                u = res[0];
            }
            else return null;
            if (item.login != null)
            {
                u.login = item.login;
            }
            if (item.lastname != null) 
            { 
                u.lastname = item.lastname;
            }
            if (item.firstname != null)
            {
                u.firstname = item.firstname;
            }
            if (item.password != null)
            {
                u.password = item.password;
            }
            _dbContext.Update(u);
            _dbContext.SaveChanges();
            return u;
        }
    }
}
