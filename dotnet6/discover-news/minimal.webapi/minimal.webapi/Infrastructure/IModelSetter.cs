namespace minimal.webapi.Infrastructure
{
    public interface IModelSetter<T> where T:class
    {
        Task<T> Add(T value);
    }
}
