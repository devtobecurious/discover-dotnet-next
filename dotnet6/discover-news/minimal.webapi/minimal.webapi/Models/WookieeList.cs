using minimal.webapi.Infrastructure;

namespace minimal.webapi.Models
{
    public class WookieeList
    {
        private readonly IModelGetter<Wookiee> getter;

        public WookieeList(IModelGetter<Wookiee> getter)
        {
            this.getter = getter;            
        }

        public Task Load()
        {
            return this.getter.GetAll();
        }
    }
}
