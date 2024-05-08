namespace BlazorMansoura.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
