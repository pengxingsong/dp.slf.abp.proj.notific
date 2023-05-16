using Volo.Abp.DependencyInjection;

namespace DP.NotificApp;

public class HelloWorldService : ITransientDependency
{
    public string SayHello()
    {
        return "Hello, World!";
    }
}