namespace TestSessions.model
{
    public class User
    {
        public String Name{ get; set; }
        public bool Admin { get; set; }

        public User(string name, bool admin=false)
        {
            Name = name;
            Admin = admin;
        }

        public User():this("dummy")
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Admin)}={Admin.ToString()}}}";
        }
    }
}
