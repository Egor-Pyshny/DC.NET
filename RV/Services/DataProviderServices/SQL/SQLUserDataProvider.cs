using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views.DTO;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public UserDTO GetUser(int id)
        {
            return _mapper.Map<UserDTO>(_dbContext.Users.Where(u => u.id == id));
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
            throw new NotImplementedException();
        }
    }
}
