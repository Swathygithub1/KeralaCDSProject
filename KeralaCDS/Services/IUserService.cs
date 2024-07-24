using KeralaCDS.Models;


namespace KeralaCDS.Services
{
    public interface IUserService
    {
        Task RegisterUser(UserDTO userdto);
    }




}
