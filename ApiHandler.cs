using System.Text.Json;

namespace apitest;
public class ApiHandler
{
    public async void Run()
    {
        string baseAdress = "https://v2.jokeapi.dev/";
        string requestUri = "joke/Any?safe-mode";

        IApiDataReader dataReader = new ApiDataReader();
        string json = await dataReader.Read(baseAdress, requestUri);
        Root? root = JsonSerializer.Deserialize<Root>(json);
        if (root != null)
        {
            Console.WriteLine("Joke found.");
            Console.WriteLine();
            if (root.setup != null) Console.WriteLine(root.setup);
            if (root.delivery != null) Console.WriteLine(root.delivery);
        }
    }
}