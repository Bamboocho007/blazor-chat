using WsBlazor.Data.DTO;

namespace WsBlazor.Data.Services
{
  public class UserApiService
  {
    private readonly HttpClient httpClient;
    public UserApiService(HttpClient _httpClient)
    {
      httpClient = _httpClient;
    }
    public async Task<User?> GetUserByName(string serchedUser)
    {
      return await httpClient.GetFromJsonAsync<User>($"http://localhost:5149/Users/{serchedUser}");
    }
  }
}