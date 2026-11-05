namespace apitest;

public interface IApiDataReader
{
    Task<string> Read(string baseAdress, string requestUri);
}