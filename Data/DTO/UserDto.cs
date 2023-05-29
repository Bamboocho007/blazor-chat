
namespace WsBlazor.Data.DTO
{
  public class User
  {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Chat> Chats { get; private set; } = new List<Chat>();
    public List<Message> Messages { get; private set; } = new List<Message>();
  }
}