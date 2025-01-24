using WebAPI.Models.Enums;
using WebAPI.Models.Shared;

namespace WebAPI.Models
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public RoleEnum Role { get; set; }

        protected User() { }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Role = RoleEnum.Admin;
        } 

        public void Update(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
