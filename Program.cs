using System.Text.Json;

namespace apitest;

class Program
{
    static async Task Main(string[] args)
    {
        string baseAdress = "https://v2.jokeapi.dev/";
        string requestUri = "joke/Any?safe-mode";

        IApiDataReader dataReader = new ApiDataReader();
        string json = await dataReader.Read(baseAdress, requestUri);
        Root? root = JsonSerializer.Deserialize<Root>(json);
        if(root != null)
        {
            if(root.setup != null) Console.WriteLine(root.setup);
            if(root.delivery != null) Console.WriteLine(root.delivery);
            
        }
        Console.ReadKey();
    }
}

public interface IApiDataReader
{
    Task<string> Read(string baseAdress, string requestUri);
}

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAdress, string requestUri)
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(baseAdress);
        HttpResponseMessage response = await client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}