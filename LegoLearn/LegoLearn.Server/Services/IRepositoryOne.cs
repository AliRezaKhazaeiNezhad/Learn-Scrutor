namespace LegoLearn.Server.Services
{
    public interface IRepositoryOne<T> where T : class
    {
        string Print(string message);
    }
}
