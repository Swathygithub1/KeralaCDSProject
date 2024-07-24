using KeralaCDS.Models;
using Microsoft.AspNetCore.Http.HttpResults;


namespace KeralaCDS.Services
{
    public class UserRepository : IUserService
    {

        private readonly MyDBContext _dbContext;
        public UserRepository(MyDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task RegisterUser(UserDTO userdto)
        {
           await _dbContext.Users.AddAsync(new User
           {

               FirstName = userdto.FirstName,
               LastName = userdto.LastName,
               Email = userdto.Email,
               Password = userdto.Password,
               ContactNumber = userdto.ContactNumber

           });
           await _dbContext.SaveChangesAsync();
            
        }
    }
}
