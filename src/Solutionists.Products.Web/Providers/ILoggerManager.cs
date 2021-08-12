namespace Solutionists.Products.Web.Providers
{
    public interface ILoggerManager
    {
        void LogInformation(string message);
        void LogError(string message);
    }
}
