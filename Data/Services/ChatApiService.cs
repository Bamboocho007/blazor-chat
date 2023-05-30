using System.Text.Json;
using WsBlazor.Data.DTO;

namespace WsBlazor.Data.Services
{
  public class ChatApiService
  {
    private readonly HttpClient httpClient;
    public ChatApiService(HttpClient _httpClient)
    {
      httpClient = _httpClient;
    }

    public async Task<Chat?> CheckAvailableChatByUsers(List<NewChatWithUsersDto> usersForCheck)
    {
      var chatResponce = await httpClient.PostAsJsonAsync<List<NewChatWithUsersDto>>($"http://localhost:5149/Chats/getByUsers", usersForCheck);

      if (chatResponce != null)
      {
        var chatStream = await chatResponce.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<Chat>(chatStream);
      }
      return null;
    }
  }
}