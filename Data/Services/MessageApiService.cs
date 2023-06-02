using myChat.Enums;
using WsBlazor.Data.DTO;

namespace WsBlazor.Data.Services
{
  public class MessageApiService
  {
    private readonly HttpClient httpClient;
    public MessageApiService(HttpClient _httpClient)
    {
      httpClient = _httpClient;
    }

    public async Task<List<Message>?> GetMessages(Guid chatId)
    {
      var data = DateTime.UtcNow;
      return await httpClient.GetFromJsonAsync<List<Message>>($"http://localhost:5149/Messages/{chatId}?Limit=10&Direction={MessageDirecton.NEXT}&From={data.ToString("o")}");
    }
  }
}