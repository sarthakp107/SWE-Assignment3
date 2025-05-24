namespace AWE_Electronics.Core.Models
{
    public abstract class User
    {
        //Maintaining Encapsulation using Properties instead of Fields
        public string UserId { get; } //Read-Only, can be set once in constructor
        public string Name { get; set; } //R/W
        public string Email { get; set; } //R/W
        public string Password { get; private set; } //Read, Privately Writable

        protected User(string name, string email, string password)
        {
            UserId = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Password = password;
        }

    }
}


