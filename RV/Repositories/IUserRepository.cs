using RV.Models;
using RV.Views.DTO;

namespace RV.Repository
{
    public interface IUserRepository
    {
        User CreateUser(User item);
        List<User> GetUsers();
        User GetUser(int id);
        User UpdateUser(User item);
        int DeleteUser(int id);
    }
}
