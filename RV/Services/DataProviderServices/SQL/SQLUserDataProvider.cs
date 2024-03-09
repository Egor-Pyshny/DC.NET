using AutoMapper;
using RV.Models;
using RV.Repository;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLUserDataProvider : IUserDataProvider
    {
        private IUserRepository _repository;
        private IMapper _mapper;

        public SQLUserDataProvider(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public UserDTO CreateUser(UserAddDTO item)
        {
            User u = _mapper.Map<User>(item);
            var res = _repository.CreateUser(u);
            return _mapper.Map<UserDTO>(res);
        }

        public int DeleteUser(int id)
        {
            int res = _repository.DeleteUser(id);
            return res;
        }

        public UserDTO GetUser(int id)
        {
            return _mapper.Map<UserDTO>(_repository.GetUser(id));
        }

        public List<UserDTO> GetUsers()
        {
            List<UserDTO> res = [];
            foreach (User u in _repository.GetUsers())
            {
                res.Add(_mapper.Map<UserDTO>(u));
            }
            return res;
        }   

        public UserDTO UpdateUser(UserUpdateDTO item)
        {
            var n = _mapper.Map<User>(item);
            var res = _repository.UpdateUser(n);
            return _mapper.Map<UserDTO>(res);
        }
    }
}
