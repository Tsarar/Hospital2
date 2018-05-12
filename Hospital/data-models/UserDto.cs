namespace Hospital
{
    public class UserDto
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public UserDto(string user, string password, string name)
        {
            User = user;
            Password = password;
            Name = name;
        }

        public UserDto()
        {
            
        }
    }
}
