using minimal.webapi.Models;

namespace minimal.webapi.Infrastructure
{
    public class WookieeSetter : IModelSetter<Wookiee>
    {
        public Task<Wookiee> Add(Wookiee value)
        {
            return Task.FromResult(value);
        }
    }
}
