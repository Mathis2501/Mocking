namespace Mocking
{
    public enum Rights
    {
        Full,
        Partial,
        None
    }
    public class User
    {

        internal Rights Rights;

        public User()
        {
        }

        public string Password { get; set; }
        public string UserName { get; set; }

        public string ViewAllEmployees()
        {
            return "Here is the list";
        }
    }
}