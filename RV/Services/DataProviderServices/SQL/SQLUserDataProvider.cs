using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLUserDataProvider : IUserDataProvider
    {
        private ApplicationContext _dbContext;
        private IMapper _mapper;

        public SQLUserDataProvider(ApplicationContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public UserDTO CreateUser(UserAddDTO item)
        {
            User u = _mapper.Map<User>(item);
            _dbContext.Add(u);
            _dbContext.SaveChanges();      
            return _mapper.Map<UserDTO>(u);
        }

        public int DeleteUser(int id)
        {
            int res = _dbContext.Users.Where(u => u.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public UserDTO GetUser(int id)
        {
            var res = _dbContext.Users.Where(u => u.id == id).ToList();
            User u;
            if (res.Count > 0)
            {
                u = res[0];
                return _mapper.Map<UserDTO>(u);
            }
            else return null;
        }

        public List<UserDTO> GetUsers()
        {
            List<UserDTO> res = [];
            foreach (User u in _dbContext.Users) {
                res.Add(_mapper.Map<UserDTO>(u));
            }
            return res;
        }

        public UserDTO UpdateUser(UserUpdateDTO item)
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
                u.lastName = item.lastname;
            }
            if (item.firstname != null)
            {
                u.firstName = item.firstname;
            }
            if (item.password != null)
            {
                u.password = item.password;
            }
            _dbContext.Update(u);
            _dbContext.SaveChanges();
            return _mapper.Map<UserDTO>(u);
        }
    }
}
