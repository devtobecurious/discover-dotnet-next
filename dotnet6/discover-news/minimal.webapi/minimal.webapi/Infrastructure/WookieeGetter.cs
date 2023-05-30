using minimal.webapi.Models;

namespace minimal.webapi.Infrastructure
{
    public class WookieeGetter : IModelGetter<Wookiee>
    {
        public Task<IList<Wookiee>> GetAll()
        {
            IList<Wookiee> list = new List<Wookiee>();
            return Task.FromResult(list);
        }
    }
}
