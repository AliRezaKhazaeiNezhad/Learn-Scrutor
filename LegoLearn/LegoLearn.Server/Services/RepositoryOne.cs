namespace LegoLearn.Server.Services
{
    public class RepositoryOne<T> : IRepositoryOne<T> where T : class
    {
        public string Print(string message)
        {
            return message;
        }
    }
}
