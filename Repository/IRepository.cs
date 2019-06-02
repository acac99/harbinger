namespace Repository
{
    public interface IRepository<T>
    {
        T Create(T message);
    }
}