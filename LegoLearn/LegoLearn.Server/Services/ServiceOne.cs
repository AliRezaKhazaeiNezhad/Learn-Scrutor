namespace LegoLearn.Server.Services
{
    public class ServiceOne : IServiceOne
    {
        public string Print()
        {
            return $"Hello {this.GetType().Name}";
        }
    }
}
