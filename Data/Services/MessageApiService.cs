namespace WsBlazor.Data.Services
{
  public class MessageApiService
  {
    private readonly HttpClient httpClient;
    public MessageApiService(HttpClient _httpClient)
    {
      httpClient = _httpClient;
    }
  }
}