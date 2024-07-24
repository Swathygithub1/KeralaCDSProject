namespace KeralaCDS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        
        public string Email { get; set; }

        public string Password { get; set; }
        public int ContactNumber {  get; set; }

        public int isActive { get; set; } = 1;

        public DateTime CreatedOn { get; set; }= DateTime.Now;

    }
    public class UserDTO
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public int ContactNumber { get; set; }
    
    }




}
