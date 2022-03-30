using LegoLearn.Server.RepositoryServices;

namespace LegoLearn.Server.Services
{
    public class ServiceOne : IServiceOne
    {
        public string Print(string message)
        {
            return message;
        }
    }
}
