namespace aspnetcore
{
    public record User(int Id, string Name);

    public class UserService
    {
        public IList<User> GetAll()
        {
            return new List<User>()
            {
                new User(1, "Hello")
            };
        }
    }
}
