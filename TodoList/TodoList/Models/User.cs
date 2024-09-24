namespace TodoList.Models
{
    public sealed class User:Entity
    {
        
        public User()
        {
             

        }

        public User(int id, string name, string surName, int age, string email, string password) : base(id)
        {
            
            Name = name;
            this.surName = surName;
            Age = age;
            Email = email;
            Password = password;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string surName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
