namespace MinialWebApi.Services
{
    public record User(int Id, string Name);

    public class UserService
    {
        public Task<IList<User>> GetAll()
        {
            IList<User> list = new List<User>()
            {
                new User(1, "Luke")
            };

            return Task.FromResult(list);
        }
    }
}
