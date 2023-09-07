namespace minimal.webapi.Infrastructure
{
    public interface IModelGetter<T> where T: class
    {
        Task<IList<T>> GetAll();
    }
}
