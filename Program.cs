namespace apitest;

class Program
{
    static void Main(string[] args)
    {
        ApiHandler handler = new ApiHandler();
        handler.Run();
        Console.WriteLine("Waiting for joke...");
        Console.WriteLine();
        Console.ReadKey();
    }
}
