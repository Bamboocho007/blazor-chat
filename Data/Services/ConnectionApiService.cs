using WsBlazor.Data.DTO;

namespace WsBlazor.Data.Services
{
  public class ConnectionApiService
  {
    private readonly HttpClient httpClient;
    public ConnectionApiService(HttpClient _httpClient)
    {
      httpClient = _httpClient;
    }

    public async Task<List<UserConnectionDto>?> GetUserConnections(Guid userId)
    {
      return await httpClient.GetFromJsonAsync<List<UserConnectionDto>>($"http://localhost:5149/Connections/{userId}");
    }
  }
}