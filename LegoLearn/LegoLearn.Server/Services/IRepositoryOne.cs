namespace LegoLearn.Server.RepositoryServices
{
    public interface IRepositoryOne<T> where T : class
    {
        string Print(string message);
    }
}
