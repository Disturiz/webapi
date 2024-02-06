public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld()
    {
        return "Hello World Douglas Isturiz";
    }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}